#!/usr/bin/env python
# -*- coding: utf-8 -*-

from PyQt5.QtWidgets import QApplication, QWidget, QVBoxLayout, QHBoxLayout, QLabel, QLineEdit, QPushButton, QFileDialog, QMessageBox
from PyQt5.QtCore import Qt
from PyQt5.QtGui import QFont
import sys
import subprocess

def replace_spaces(input_str):
    numbers = input_str.strip().split()
    cgxml_numbers = [num + ".cgxml" for num in numbers if num]
    return " ".join(cgxml_numbers)

class App(QWidget):
    def __init__(self):
        super().__init__()

        self.initUI()

    def initUI(self):
        layout = QVBoxLayout()

        self.label1 = QLabel('Introduceți numerele cadastrale (separate de un spațiu)', self)
        self.label1.setFont(QFont('Arial', 14))
        layout.addWidget(self.label1)

        self.cadastre_numbers_entry = QLineEdit(self)
        self.cadastre_numbers_entry.setFont(QFont('Arial', 14))
        self.cadastre_numbers_entry.setAlignment(Qt.AlignCenter)
        self.cadastre_numbers_entry.setPlaceholderText('Aici introduceți numerele cadastrale...')
        layout.addWidget(self.cadastre_numbers_entry)

        self.label2 = QLabel('Introduceți numele fișierului ZIP (opțional)', self)
        self.label2.setFont(QFont('Arial', 14))
        layout.addWidget(self.label2)

        self.zip_file_entry = QLineEdit(self)
        self.zip_file_entry.setFont(QFont('Arial', 14))
        self.zip_file_entry.setAlignment(Qt.AlignCenter)
        self.zip_file_entry.setPlaceholderText('Aici introduceți numele fișierului ZIP...')
        layout.addWidget(self.zip_file_entry)

        self.zip_file_entry.textChanged.connect(self.validate_zip_name)

        self.cadastre_numbers_entry.returnPressed.connect(self.run_command)
        self.zip_file_entry.returnPressed.connect(self.run_command)

        self.button = QPushButton('Continuă', self)
        self.button.clicked.connect(self.run_command)
        layout.addWidget(self.button)

        self.setLayout(layout)
        self.setWindowTitle('Copiere și Arhivare CGXML')

    def run_command(self):
        input_str = self.cadastre_numbers_entry.text()
        source_folder = QFileDialog.getExistingDirectory(self, 'Alegeți folder-ul sursă')
        if not source_folder:
            QMessageBox.warning(self, 'Avertizare', 'Alegeți un folder sursă pentru a continua.')
            return
        dest_folder = QFileDialog.getExistingDirectory(self, 'Alegeți folder-ul de destinație')
        if not dest_folder:
            QMessageBox.warning(self, 'Avertizare', 'Alegeți un folder de destinație pentru a continua.')
            return


        zip_file = self.zip_file_entry.text() if self.zip_file_entry.text() else 'cgxml'

        if input_str and source_folder and dest_folder:
            replaced_input = replace_spaces(input_str)
            robocopy_command = f'robocopy "{source_folder}" "{dest_folder}" {replaced_input}'
            zip_command = f'powershell Compress-Archive -Path "{dest_folder}\\*" -DestinationPath "{dest_folder}\\{zip_file}.zip"'

            subprocess.run(robocopy_command, shell=True)
            subprocess.run(zip_command, shell=True)

            QMessageBox.information(self, 'Success', 'Copierea și arhivarea fișierelor a fost realizată cu succes!')
            self.close()

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
