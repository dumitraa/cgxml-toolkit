from PyQt5.QtWidgets import QProgressBar, QApplication, QWidget, QVBoxLayout, QLabel, QLineEdit, QPushButton, QFileDialog, QMessageBox, QSpacerItem, QSizePolicy
from PyQt5.QtGui import QIcon
from PyQt5.QtCore import pyqtSignal, QProcess, Qt
import sys
import os
import shutil
import zipfile

def replace_spaces(input_str):
    numbers = input_str.strip().split()
    cgxml_numbers = [num + ".cgxml" for num in numbers if num]
    return " ".join(cgxml_numbers)

class App(QWidget):
    stop_process_signal = pyqtSignal()  # Define the signal

    def __init__(self):
        super().__init__()
        self.initUI()
        self.process = QProcess(self)
        self.current_process = None  # To keep track of the current subprocess

    def closeEvent(self, event):
        if self.current_process:  # Check if there is an ongoing process
            reply = QMessageBox.question(self, 'Mesaj', 
                                         "Sunteți sigur că doriți să opriți operațiunea?", 
                                         QMessageBox.Yes | QMessageBox.No, 
                                         QMessageBox.No)
            if reply == QMessageBox.Yes: 
                self.stop_process_signal.emit()  # Emit the signal to stop the process
                event.accept()
        else:
            event.accept()  # If no process is running, just close

    def stop_process(self):
        if self.current_process:
            self.current_process.terminate()  # Terminate the subprocess

    def initUI(self):
        self.setStyleSheet("""
            QWidget {
                background-color: #F0FAFF; /* Light blue background */
                color: #000000;
                font-family: 'Segoe UI';
            }
            QLabel {
                font-weight: bold; /* Make labels bold */
                font-size: 14px;
            }
            QLineEdit {
                border: 1px solid #C0C0C0;
                border-radius: 2px;
                padding: 5px 3px; /* Adjusted padding */
                background-color: #FFFFFF;
                color: #000000;
                font-size: 14px; /* Slightly larger font size */
            }
            QLineEdit[valid="true"] {
                border: 1px solid #C0C0C0; /* Default border color for valid input */
            }
            QLineEdit[valid="false"] {
                border: 1px solid red; /* Red border color for invalid input */
                color: red; /* Optional: make text red if input is invalid */
            }
            QPushButton {
                border: 1px solid #0057D8; /* A more noticeable border color */
                border-radius: 2px;
                padding: 5px;
                background-color: #F0F0F0;
                color: #0057D8; /* Text color that matches the border */
                font-size: 14px; /* Slightly larger font size */
            }
            QPushButton:hover {
                background-color: #DCE6F1; /* A light blue background on hover */
                border-color: #003C9D; /* Darker border on hover for contrast */
            }
            QPushButton:pressed {
                background-color: #C0D4E4; /* A darker blue for the pressed state */
            }
            QProgressBar {
                border: 1px solid #C0C0C0;
                border-radius: 5px;
                background-color: #FFFFFF;
                text-align: center;
            }
            QProgressBar::chunk {
                background-color: #0057D8;
                width: 20px; /* Chunk size */
            }
        """)
        
        self.setWindowTitle('Copiere și Arhivare CGXML')
        self.setWindowIcon(QIcon('C:/Users/USER/Documents/scripts/cgxml-toolkit/UtilitatiCGXML/Neural.ico'))  # Set an icon 
        
        layout = QVBoxLayout()

        self.label1 = QLabel('Introduceți numerele cadastrale (separate de un spațiu)', self)
        layout.addWidget(self.label1)

        self.cadastre_numbers_entry = QLineEdit(self)
        self.cadastre_numbers_entry.setPlaceholderText('Aici introduceți numerele cadastrale...')
        layout.addWidget(self.cadastre_numbers_entry)

        self.label2 = QLabel('Introduceți numele fișierului ZIP (opțional)', self)
        layout.addWidget(self.label2)

        self.zip_file_entry = QLineEdit(self)
        self.zip_file_entry.setPlaceholderText('Aici introduceți numele fișierului ZIP...')
        layout.addWidget(self.zip_file_entry)

        self.zip_file_entry.textChanged.connect(self.validate_zip_name)

        self.cadastre_numbers_entry.returnPressed.connect(self.run_command)
        self.zip_file_entry.returnPressed.connect(self.run_command)

        self.progress_bar = QProgressBar(self)
        self.progress_bar.setAlignment(Qt.AlignCenter)
        layout.addWidget(self.progress_bar)
        
        self.button = QPushButton('Continuă')
        self.button.clicked.connect(self.run_command)
        layout.addWidget(self.button)
        
        spacer = QSpacerItem(20, 40, QSizePolicy.Minimum, QSizePolicy.Expanding)
        layout.addItem(spacer)

        self.setLayout(layout)
        self.setGeometry(300, 300, 600, 150) 

    # Modified run_command method
    def run_command(self):
        def calculate_total_size(file_paths):
            return sum(os.path.getsize(f) for f in file_paths if os.path.exists(f))

        def copy_files(source_folder, dest_folder, file_names, progress_callback):
            not_found_files = []
            for file_name in file_names:
                source_path = os.path.join(source_folder, file_name)
                if os.path.exists(source_path):
                    dest_path = os.path.join(dest_folder, file_name)
                    shutil.copy2(source_path, dest_path)
                    progress_callback(source_path)  # Update progress
                else:
                    not_found_files.append(file_name.replace('.cgxml', ''))
            return not_found_files

        def zip_files(source_folder, dest_file, file_names, progress_callback):
            with zipfile.ZipFile(dest_file, 'w') as zipf:
                for file_name in file_names:
                    file_path = os.path.join(source_folder, file_name)
                    if os.path.exists(file_path):
                        zipf.write(file_path, os.path.basename(file_path))
                        progress_callback(file_path)  # Update progress
                    
        def update_progress(file_path):
            nonlocal copied_size
            copied_size += os.path.getsize(file_path)
            progress = int((copied_size / total_size) * 100)
            self.progress_bar.setValue(progress)
                
        input_str = list(set(self.cadastre_numbers_entry.text().split()))  # Remove duplicates
        
        source_folder = QFileDialog.getExistingDirectory(self, 'Alegeți folder-ul sursă')
        if not source_folder:
            QMessageBox.warning(self, 'Avertizare', 'Alegeți un folder sursă pentru a continua.')
            return
        
        dest_folder = QFileDialog.getExistingDirectory(self, 'Alegeți folder-ul de destinație')
        if not dest_folder:
            QMessageBox.warning(self, 'Avertizare', 'Alegeți un folder de destinație pentru a continua.')
            return
        
        if input_str and source_folder and dest_folder:
            file_names = [f"{num}.cgxml" for num in input_str]  # Construct file names based on input
            total_size = calculate_total_size([os.path.join(source_folder, f) for f in file_names])
            copied_size = 0

        # Copy files
        not_found_files = copy_files(source_folder, dest_folder, file_names, update_progress)

        # Zip files
        zip_file_name = self.zip_file_entry.text().strip() or "cgxml"
        zip_file_path = os.path.join(dest_folder, f"{zip_file_name}.zip")
        zip_files(dest_folder, zip_file_path, file_names, update_progress)

        success_msg = f"Fișierele au fost copiate și arhivate cu succes!\nFișiere copiate: {len(file_names) - len(not_found_files)}/{len(file_names)}"
        if not_found_files:
            success_msg += f"\n{len(not_found_files)} fișiere negăsite: {', '.join(not_found_files)}"
        QMessageBox.information(self, 'Succes', success_msg)
        self.progress_bar.setValue(100)  # Ensure progress bar is full at the end

    def validate_zip_name(self):
        invalid_chars = ['\\', '/', ':', '*', '?', '"', '<', '>', '|']
        text = self.zip_file_entry.text()

        if any(char in text for char in invalid_chars):
            self.zip_file_entry.setStyleSheet("border: 1px solid red;")
            QMessageBox.warning(self, 'Nume invalid', 'Numele arhivei conține unul sau mai multe caractere invalide (\ / : * ? " < > |).\n Vă rugăm să folosiți alt nume.')
        else:
            self.zip_file_entry.setStyleSheet("border: 1px solid green;")
    
if __name__ == '__main__':
    app = QApplication(sys.argv)
    ex = App()
    ex.show()
    sys.exit(app.exec_())
