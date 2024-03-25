using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GeoAPI.Geometries;
using NetTopologySuite;
using NetTopologySuite.IO;
using NetTopologySuite.Features;
using DaveChambers.FolderBrowserDialogEx;
using Microsoft.VisualBasic.CompilerServices;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.SS.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.Util;
using nc;
using NPOI.SS.Formula.Eval;
using NPOI.SS.Formula.Functions;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace UtilitatiCGXML
{
    public partial class CustomControl1 : UserControl
    {

        private void eVisible(bool state)
        {
            filePrefix.Visible = state;
            //button
            button7.Visible = state;
            //comboBox
            comboBox1.Visible = state;
            //label
            waitMilliseconds.Visible = state;
            seVaCreaLabel.Visible = state;
            //pictureBox
            backgroundImageLogo.Visible = state;
        }
        public CustomControl1()
        {
            InitializeComponent();
            StylePanelAndButtons();
        }

        #region  Designer Components
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (button7.Visible == true)
            {
                button7.Visible = false;
            }
            if (filePrefix.Visible == true)
            {
                filePrefix.Visible = false;
            }
            if (button7.Visible == true)
            {
                button7.Visible = false;
            }
            if (waitMilliseconds.Visible == true)
            {
                waitMilliseconds.Visible = false;
            }
            if (seVaCreaLabel.Visible == true)
            {
                seVaCreaLabel.Visible = false;
            }
            if (backgroundImageLogo.Visible == false)
            {
                backgroundImageLogo.Visible = true;
            }
        }

        private async void copyArchiveCgBtn_Click(object sender, EventArgs e)
        {
            this.copyArchiveCgBtn.Enabled = false;
            string exePath = @"C:\Users\USER\Documents\scripts\cgxml-toolkit\UtilitatiCGXML\Resources\copyArchiveCgxml\dist\copyArchiveCg.exe";
            ProcessStartInfo startInfo = new ProcessStartInfo(exePath)
            {
                UseShellExecute = false, // Set to false to redirect output
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Reading output asynchronously
                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                await Task.Run(() => process.WaitForExit());

                Console.WriteLine("Output: " + output);
                Console.WriteLine("Error: " + error);
                this.copyArchiveCgBtn.Enabled = true;
            }
        }



        private void copyArchiveCgBtn_MouseHover(object sender, EventArgs e)
        {

        }
        class Verificator
        {
            public int icadgenno { get; set; }
            public string sector { get; set; }
            public string ie { get; set; }
            public string lbpartno { get; set; }
        }

/* 
        private void raportParcelaBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string fileName = "Parcela";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }

            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;

            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Are Geometrie?");
            headerRow.CreateCell(4).SetCellValue("Nr CAD");
            headerRow.CreateCell(5).SetCellValue("Nr CF");
            headerRow.CreateCell(6).SetCellValue("Nr TOPO");
            headerRow.CreateCell(7).SetCellValue("Proprietari");
            headerRow.CreateCell(8).SetCellValue("Suprafata Masurata");
            headerRow.CreateCell(9).SetCellValue("Suprafata din Acte");
            headerRow.CreateCell(10).SetCellValue("Diferenta de suprafata");
            headerRow.CreateCell(11).SetCellValue("Nr Titlu");
            headerRow.CreateCell(12).SetCellValue("Nr Tarla");
            headerRow.CreateCell(13).SetCellValue("Nr Parcela");
            headerRow.CreateCell(14).SetCellValue("Suprafata Parcela");
            headerRow.CreateCell(15).SetCellValue("Categorie de folosinta");
            headerRow.CreateCell(16).SetCellValue("Imprejmuit");
            headerRow.CreateCell(17).SetCellValue("Tip teren");
            headerRow.CreateCell(18).SetCellValue("Note Imobil");
            headerRow.CreateCell(19).SetCellValue("Note Parcela");
            headerRow.CreateCell(20).SetCellValue("Note Proprietar");
            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);


            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 19));


            int rowIndex = 1;


            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                //Populate Raport
                //set vars
                //bool b = AllFileListz.Any(files[i].FullName.Contains);
                bool b = AllFileListz.Any(s => files[i].FullName.Contains(s));
                bool c = MustFileListz.Any(files[i].FullName.Contains);


                //actions
                if (checkBox1.Checked == true)
                {

                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        ie = lr.E2IDENTIFIER;
                        measarea = lr.MEASUREDAREA.ToString();
                        if (lr.PARCELLEGALAREA == 9898989)
                        {
                            parcellegalarea = "Necompletat";
                        }
                        else
                        {
                            parcellegalarea = lr.PARCELLEGALAREA.ToString();
                        }
                        dif = (lr.PARCELLEGALAREA - lr.MEASUREDAREA).ToString();
                        note = lr.NOTES;
                        enclosed = lr.ENCLOSED ? "DA" : "NU";
                        foreach (CGXML.PersonRow pp in fisier.Person)
                        {
                            string fullName = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                            proprietar = fullName;
                            pnotes = pp.NOTES;
                        }
                        foreach (CGXML.ParcelRow pr in fisier.Parcel)
                        {
                            nrtopo = pr.TOPONO.ToString();
                            titleno = pr.TITLENO.ToString();
                            landplotno = pr.LANDPLOTNO;
                            parcelno = pr.PARCELNO;
                            parcelarea = pr.MEASUREDAREA.ToString();
                            cat = pr.USECATEGORY;
                            intra = pr.INTRAVILAN ? "Intravilan" : "Extravilan";
                            notes = pr.NOTES;
                            nrcad = pr.PAPERCADNO;
                            nrcf = pr.PAPERLBNO;
                            nrtopo = pr.TOPONO;
                            if (RandomListz.Any(fo.FullName.Contains))
                            {
                                var row = sheet.CreateRow(rowIndex);
                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(fisier.Points.Count > 0 ? "DA" : "NU");
                                row.CreateCell(4).SetCellValue(nrcad);
                                row.CreateCell(5).SetCellValue(nrcf);
                                row.CreateCell(6).SetCellValue(nrtopo);
                                row.CreateCell(7).SetCellValue(proprietar);
                                row.CreateCell(8).SetCellValue(measarea);
                                row.CreateCell(9).SetCellValue(parcellegalarea);
                                row.CreateCell(10).SetCellValue(dif);
                                row.CreateCell(11).SetCellValue(titleno);
                                row.CreateCell(12).SetCellValue(landplotno);
                                row.CreateCell(13).SetCellValue(parcelno);
                                row.CreateCell(14).SetCellValue(parcelarea);
                                row.CreateCell(15).SetCellValue(cat);
                                row.CreateCell(16).SetCellValue(enclosed);
                                row.CreateCell(17).SetCellValue(intra);
                                row.CreateCell(18).SetCellValue(note);
                                row.CreateCell(19).SetCellValue(notes);
                                row.CreateCell(20).SetCellValue(pnotes);

                                rowIndex++;
                            }
                        }
                    }

                }
                else
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        ie = lr.E2IDENTIFIER;
                        measarea = lr.MEASUREDAREA.ToString();
                        if (lr.PARCELLEGALAREA == 9898989)
                        {
                            parcellegalarea = "Necompletat";
                        }
                        else
                        {
                            parcellegalarea = lr.PARCELLEGALAREA.ToString();
                        }
                        dif = (lr.PARCELLEGALAREA - lr.MEASUREDAREA).ToString();
                        note = lr.NOTES;
                        enclosed = (lr.ENCLOSED ? "DA" : "NU");

                        HashSet<string> uniquePerson = new HashSet<string>();
                        string fullName = "";
                        string proprietar = "";
                        string person = "";

                        foreach (CGXML.PersonRow pp in fisier.Person)
                        {
                            fullName = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                            person = fullName.Trim();
                            uniquePerson.Add(fullName);
                        }

                        string aggregatedOwners = string.Join("; ", uniquePerson);
                        proprietar = aggregatedOwners;

                        foreach (CGXML.ParcelRow pr in fisier.Parcel)
                        {
                            nrtopo = pr.TOPONO.ToString();
                            titleno = pr.TITLENO.ToString();
                            landplotno = pr.LANDPLOTNO;
                            parcelno = pr.PARCELNO;
                            parcelarea = pr.MEASUREDAREA.ToString();
                            cat = pr.USECATEGORY;
                            intra = (pr.INTRAVILAN ? "Intravilan" : "Extravilan");
                            notes = pr.NOTES;
                            nrcad = pr.PAPERCADNO;
                            nrcf = pr.PAPERLBNO;
                            nrtopo = pr.TOPONO;

                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(fisier.Points.Count > 0 ? "DA" : "NU");
                            row.CreateCell(4).SetCellValue(nrcad);
                            row.CreateCell(5).SetCellValue(nrcf);
                            row.CreateCell(6).SetCellValue(nrtopo);
                            row.CreateCell(7).SetCellValue(proprietar);
                            row.CreateCell(8).SetCellValue(measarea);
                            row.CreateCell(9).SetCellValue(parcellegalarea);
                            row.CreateCell(10).SetCellValue(dif);
                            row.CreateCell(11).SetCellValue(titleno);
                            row.CreateCell(12).SetCellValue(landplotno);
                            row.CreateCell(13).SetCellValue(parcelno);
                            row.CreateCell(14).SetCellValue(parcelarea);
                            row.CreateCell(15).SetCellValue(cat);
                            row.CreateCell(16).SetCellValue(enclosed);
                            row.CreateCell(17).SetCellValue(intra);
                            row.CreateCell(18).SetCellValue(note);
                            row.CreateCell(19).SetCellValue(notes);
                            row.CreateCell(20).SetCellValue(pnotes);
                            rowIndex++;
                        }
                    }

                }
            }
            //Write the stream data of workbook to the root directory
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            this.Cursor = Cursors.Default;
        }


        private void raportConstructiiBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            bool hasBuildings = false;

            string[] filezz = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer nss = new NumericComparer();
            System.Array.Sort(filezz, nss);

            foreach (string filee in filezz)
            {
                CGXML fisier = new CGXML();
                try
                {
                    fisier.ReadXml(filee);
                    if (fisier.Building.Count > 0)
                    {
                        hasBuildings = true;
                        break; // Exit the loop as soon as we find a file with buildings
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Error reading file {filee}: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return; // Exit the method if there's an error reading a file
                }
            }

            if (!hasBuildings)
            {
                MessageBox.Show("Nu s-au găsit construcții în fișierele .cgxml selectate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return; // Exit the method since no buildings were found
            }

            string fileName = "Constructii";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Nr C");
            headerRow.CreateCell(4).SetCellValue("Proprietar");
            headerRow.CreateCell(5).SetCellValue("Legal?");
            headerRow.CreateCell(6).SetCellValue("Suprafata Masurata");
            headerRow.CreateCell(7).SetCellValue("Suprafata Legala");
            headerRow.CreateCell(8).SetCellValue("Destinatie");
            headerRow.CreateCell(9).SetCellValue("Nr Etaje");
            headerRow.CreateCell(10).SetCellValue("Note Constructii");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 8));


            int rowIndex = 1;

            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                //Populate Raport
                //actions

                if (checkBox1.Checked == true)
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        ie = lr.E2IDENTIFIER;
                        if (lr.BUILDINGLEGALAREA == 9898989)
                        {
                            BLA = "Necompletat";
                        }
                        else
                        {
                            BLA = lr.BUILDINGLEGALAREA.ToString();
                        }
                        foreach (CGXML.PersonRow pp in fisier.Person)
                        {
                            proprietar = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                            foreach (CGXML.BuildingRow br in fisier.Building)
                            {
                                buildingid = br.BUILDINGID.ToString();
                                measuredarea = br.MEASUREDAREA.ToString();
                                destinatie = br.BUILDINGDESTINATION;
                                legalbuilding = br.ISLEGAL ? "DA" : "NU";
                                bnotes = br.NOTES;
                                nivel = br.LEVELSNO.ToString();
                                if (br.LEGALAREA == 9898989)
                                {
                                    legalarea = "Necompletat";
                                }
                                else
                                {
                                    legalarea = br.LEGALAREA.ToString();
                                }
                                if (RandomListz.Any(fo.FullName.Contains))
                                {
                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(buildingid);
                                    row.CreateCell(4).SetCellValue(proprietar);
                                    row.CreateCell(5).SetCellValue(legalbuilding);
                                    row.CreateCell(6).SetCellValue(measuredarea);
                                    row.CreateCell(7).SetCellValue(legalarea);
                                    row.CreateCell(8).SetCellValue(destinatie);
                                    row.CreateCell(9).SetCellValue(nivel);
                                    row.CreateCell(10).SetCellValue(bnotes);

                                    rowIndex++;
                                }
                            }
                        }

                    }

                }
                else
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        ie = lr.E2IDENTIFIER;
                        if (lr.BUILDINGLEGALAREA == 9898989)
                        {
                            BLA = "Necompletat";
                        }
                        else
                        {
                            BLA = lr.BUILDINGLEGALAREA.ToString();
                        }

                        foreach (CGXML.PersonRow pp in fisier.Person)
                        {
                            proprietar = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                            foreach (CGXML.BuildingRow br in fisier.Building)
                            {
                                buildingid = br.BUILDINGID.ToString();
                                measuredarea = br.MEASUREDAREA.ToString();
                                destinatie = br.BUILDINGDESTINATION;
                                legalbuilding = br.ISLEGAL ? "DA" : "NU";
                                bnotes = br.NOTES;
                                nivel = br.LEVELSNO.ToString();
                                if (br.LEGALAREA == 9898989)
                                {
                                    legalarea = "Necompletat";
                                }
                                else
                                {
                                    legalarea = br.LEGALAREA.ToString();
                                }

                                var row = sheet.CreateRow(rowIndex);

                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(buildingid);
                                row.CreateCell(4).SetCellValue(proprietar);
                                row.CreateCell(5).SetCellValue(legalbuilding);
                                row.CreateCell(6).SetCellValue(measuredarea);
                                row.CreateCell(7).SetCellValue(legalarea);
                                row.CreateCell(8).SetCellValue(destinatie);
                                row.CreateCell(9).SetCellValue(nivel);
                                row.CreateCell(10).SetCellValue(bnotes);

                                rowIndex++;

                            }
                        }
                    }
                }
            }

            //Write the stream data of workbook to the root directory
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            this.Cursor = Cursors.Default;
        }

        private void raportSarciniBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string raportname = "Raport Sarcini";
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Sarcini");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 3));


            int rowIndex = 1;

            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }

                //Populate Raport
                //actions

                foreach (CGXML.RegistrationRow lb in fisier.Registration)
                {
                    bool hasSarcini = false;
                    if (lb.LBPARTNO == 3) {
                        hasSarcini = true;
                    }
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            cadgenno = lr.CADGENNO;
                            sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                            ie = lr.E2IDENTIFIER;

                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(hasSarcini ? "DA" : "NU");

                            rowIndex++;

                        }
                }
            }
            //Write the stream data of workbook to the root directory
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            this.Cursor = Cursors.Default;
        }

        private void raportTipInscrieriBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string fileName = "Tip Inscrieri";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Suprafata Masurata");
            headerRow.CreateCell(4).SetCellValue("Tip Inscriere");
            headerRow.CreateCell(5).SetCellValue("Nr");
            headerRow.CreateCell(6).SetCellValue("Data");
            headerRow.CreateCell(7).SetCellValue("Tip Act");
            headerRow.CreateCell(8).SetCellValue("Emitent");
            headerRow.CreateCell(9).SetCellValue("Note Inscriere");
            headerRow.CreateCell(10).SetCellValue("Note Acte");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);

            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 8));


            int rowIndex = 1;

            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                //Populate Raport
                //actions
                if (checkBox1.Checked == true)
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        sup = lr.MEASUREDAREA.ToString();
                        ie = lr.E2IDENTIFIER;
                    }
                    foreach (CGXML.RegistrationRow lb in fisier.Registration)
                    {
                        if (lb.REGISTRATIONTYPE == "NOTATION")
                        {
                            regtype = "Notare";
                        }
                        if (lb.REGISTRATIONTYPE == "POSESION_REGISTATION")
                        {
                            regtype = "Inscrierea posesiei";
                        }
                        if (lb.REGISTRATIONTYPE == "PROVISIONALENTRY")
                        {
                            regtype = "Inscrierea provizorie";
                        }
                        if (lb.REGISTRATIONTYPE == "INTAB")
                        {
                            regtype = "Intabulare";
                        }
                        string regnotes = lb.COMMENTS;

                        foreach (CGXML.DeedRow lm in fisier.Deed)
                        {
                            string deed = lm.DEEDNUMBER;
                            string deeddate = lm.DEEDDATE.ToString();
                            string deednote = lm.NOTES;
                            if (lm.DEEDTYPE == "ACT_NOTARIAL")
                            {
                                deedtype = "Act Notarial";
                            }
                            if (lm.DEEDTYPE == "ADMINISTRATIVE_1")
                            {
                                deedtype = "Act Administrativ";
                            }
                            else
                            {
                                deedtype = lm.DEEDTYPE;
                            }

                            string deedautority = lm.AUTHORITY;

                            if (RandomListz.Any(fo.FullName.Contains))
                            {
                                var row = sheet.CreateRow(rowIndex);

                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(sup);
                                row.CreateCell(4).SetCellValue(regtype);
                                row.CreateCell(5).SetCellValue(deed);
                                row.CreateCell(6).SetCellValue(deeddate);
                                row.CreateCell(7).SetCellValue(deedtype);
                                row.CreateCell(8).SetCellValue(deedautority);
                                row.CreateCell(9).SetCellValue(regnotes);
                                row.CreateCell(10).SetCellValue(deednote);

                                rowIndex++;
                            }
                        }
                    }

                }
                else
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                        sup = lr.MEASUREDAREA.ToString();
                        ie = lr.E2IDENTIFIER;
                    }
                    foreach (CGXML.RegistrationRow lb in fisier.Registration)
                    {
                        if (lb.REGISTRATIONTYPE == "NOTATION")
                        {
                            regtype = "Notare";
                        }
                        if (lb.REGISTRATIONTYPE == "POSESION_REGISTATION")
                        {
                            regtype = "Inscrierea posesiei";
                        }
                        if (lb.REGISTRATIONTYPE == "PROVISIONALENTRY")
                        {
                            regtype = "Inscrierea provizorie";
                        }
                        if (lb.REGISTRATIONTYPE == "INTAB")
                        {
                            regtype = "Intabulare";
                        }
                        string regnotes = lb.COMMENTS;

                        foreach (CGXML.DeedRow lm in fisier.Deed)
                        {
                            string deed = lm.DEEDNUMBER;
                            string deeddate = lm.DEEDDATE.ToString("dd/MM/yyyy");
                            string deednote = lm.NOTES;
                            if (lm.DEEDTYPE == "ACT_NOTARIAL")
                            {
                                deedtype = "Act Notarial";
                            }
                            if (lm.DEEDTYPE == "ADMINISTRATIVE_1")
                            {
                                deedtype = "Act Administrativ";
                            }
                            else
                            {
                                deedtype = lm.DEEDTYPE;
                            }

                            string deedautority = lm.AUTHORITY;

                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(sup);
                            row.CreateCell(4).SetCellValue(regtype);
                            row.CreateCell(5).SetCellValue(deed);
                            row.CreateCell(6).SetCellValue(deeddate);
                            row.CreateCell(7).SetCellValue(deedtype);
                            row.CreateCell(8).SetCellValue(deedautority);
                            row.CreateCell(9).SetCellValue(regnotes);
                            row.CreateCell(10).SetCellValue(deednote);

                            rowIndex++;

                        }
                    }
                }
            }
            //Write the stream data of workbook to the root directory

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            this.Cursor = Cursors.Default;
        }

        private void raportProprietariBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string fileName = "Proprietar";
            string raportname = "";
            if (checkBox1.Checked == true)
            {
                raportname = string.Concat("Raport ", fileName, " esantion");
            }
            else
            {
                raportname = string.Concat("Raport ", fileName);
            }
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Proprietar");
            headerRow.CreateCell(4).SetCellValue("Tip Persoana");
            headerRow.CreateCell(5).SetCellValue("CNP/CUI");
            headerRow.CreateCell(6).SetCellValue("Defunct");
            headerRow.CreateCell(7).SetCellValue("Adresa");
            headerRow.CreateCell(8).SetCellValue("Note");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 6));


            int rowIndex = 1;
            DataSet dsUAT = new DataSet();
            DataSet dsLocality = new DataSet();
            DataSet dsStreetType = new DataSet();
            dsUAT.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Admin.xml"));
            dsLocality.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Locality.xml"));
            dsStreetType.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Dictionary.xml"));

            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();

            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                //Populate Raport
                //set vars

                //actions
                if (checkBox1.Checked == true)
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        ie = lr.E2IDENTIFIER;
                        cadgenno = lr.CADGENNO;
                        DataTable item = fisier.Tables["ADDRESS"];
                        int aDDRESSID = lr.ADDRESSID;
                        DataRow[] drAddress = item.Select($"ADDRESSID={aDDRESSID}");
                        // Initialize UAT_land to a default value or null
                        string UAT_land = null;

                        if (drAddress.Length > 0 && drAddress[0].ItemArray.Length > 1)
                        {
                            // Safely attempt to access the data
                            var administrativeUnitId = drAddress[0][1].ToString();

                            DataRow[] uatRows = dsUAT.Tables[0].Select($"ADMINISTRATIVEUNITID='{administrativeUnitId}'");

                            if (uatRows.Length > 0 && uatRows[0].ItemArray.Length > 2)
                            {
                                UAT_land = uatRows[0][2].ToString();
                                UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                            }
                            else
                            {
                                Console.WriteLine($"No rows found in dsUAT.Tables[0] for ADMINISTRATIVEUNITID='{administrativeUnitId}', or column index 2 is missing.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No rows found for ADDRESSID={aDDRESSID} in 'ADDRESS' table, or the row does not contain enough data.");
                        }

                        string sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? $"S{lr.CADSECTOR}" : string.Empty;
                    }
                    foreach (CGXML.PersonRow pr in fisier.Person)
                    {
                        proprietar = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                        proprietar = proprietar.Replace("|", "");
                        isPhysical = pr.ISPHYSICAL ? "Fizica" : "Juridica";
                        Console.WriteLine($"isPhysical: {isPhysical}");
                        defunct = pr.DEFUNCT ? "DA" : "NU";
                        note = pr.NOTES;
                        cnp = pr.IDCODE != string.Empty ? pr.IDCODE : "9999999999999";
                        int addressid = pr.ADDRESSID;
                        DataRow[] drAddress = fisier.Tables["ADDRESS"].Select(string.Concat("ADDRESSID=", addressid.ToString()));
                        if (!string.IsNullOrEmpty(drAddress[0][1].ToString()))
                        {
                            try
                            {
                                DataRow[] drUAT = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"));
                                adresa = string.Concat("UAT ", drUAT[0][2]);
                                if (drAddress[0][3].ToString().ToLower() == "true")
                                {
                                    DataRow[] drLocality = dsLocality.Tables[0].Select(string.Concat("LOCALITYID='", drAddress[0][2], "'"));
                                    adresa = string.Concat(new object[] { adresa, ", Loc. ", drLocality[0][2], ", " });
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("DISTRICTTYPE") && !string.IsNullOrEmpty(drAddress[0][4].ToString()))
                                    {
                                        DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["DISTRICTTYPE"], "' AND DICTIONARYCODE='DISTRICT'"));
                                        adresa = string.Concat(new object[] { adresa, drDict[0][3], " ", drAddress[0][5] });
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("STREETTYPE") && !string.IsNullOrEmpty(drAddress[0][6].ToString()))
                                    {
                                        DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["STREETTYPE"], "' AND DICTIONARYCODE='ST'"));
                                        adresa = string.Concat(new object[] { adresa, ", ", drDict[0][3], " ", drAddress[0][7] });
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("POSTALNUMBER") && !string.IsNullOrEmpty(drAddress[0][8].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Nr. ", drAddress[0][8]);
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("BLOCK") && !string.IsNullOrEmpty(drAddress[0][9].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Bloc ", drAddress[0][9]);
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("ENTRY") && !string.IsNullOrEmpty(drAddress[0][10].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Sc. ", drAddress[0][10]);
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("FLOOR") && !string.IsNullOrEmpty(drAddress[0][11].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Et. ", drAddress[0][11]);
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("APNO") && !string.IsNullOrEmpty(drAddress[0][12].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Ap. ", drAddress[0][12]);
                                    }
                                    if (fisier.Tables["ADDRESS"].Columns.Contains("ZIPCODE") && !string.IsNullOrEmpty(drAddress[0][13].ToString()))
                                    {
                                        adresa = string.Concat(adresa, ", Cod postal ", drAddress[0][13]);
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(string.Concat(cadgenno, " cu probleme"));
                            }
                        }
                        else
                        {
                            adresa = "Nespecificata";
                        }
                        if (RandomListz.Any(fo.FullName.Contains))
                        {
                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(proprietar);
                            row.CreateCell(4).SetCellValue(isPhysical);
                            row.CreateCell(5).SetCellValue(cnp);
                            row.CreateCell(6).SetCellValue(defunct);
                            row.CreateCell(7).SetCellValue(adresa);
                            row.CreateCell(8).SetCellValue(note);

                            rowIndex++;
                        }
                    }
                }
                else
                {
                    foreach (CGXML.LandRow lr in fisier.Land)
                    {
                        cadgenno = lr.CADGENNO;
                        ie = lr.E2IDENTIFIER;
                        DataTable item = fisier.Tables["ADDRESS"];
                        int aDDRESSID = lr.ADDRESSID;
                        DataRow[] drAddress = item.Select($"ADDRESSID={aDDRESSID}");

                        // Initialize UAT_land to a default value or null
                        string UAT_land = null;

                        if (drAddress.Length > 0 && drAddress[0].ItemArray.Length > 1)
                        {
                            // Safely attempt to access the data
                            var administrativeUnitId = drAddress[0][1].ToString();

                            DataRow[] uatRows = dsUAT.Tables[0].Select($"ADMINISTRATIVEUNITID='{administrativeUnitId}'");

                            if (uatRows.Length > 0 && uatRows[0].ItemArray.Length > 2)
                            {
                                UAT_land = uatRows[0][2].ToString();
                                UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                            }
                            else
                            {
                                Console.WriteLine($"No rows found in dsUAT.Tables[0] for ADMINISTRATIVEUNITID='{administrativeUnitId}', or column index 2 is missing.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No rows found for ADDRESSID={aDDRESSID} in 'ADDRESS' table, or the row does not contain enough data.");
                        }

                        string sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? $"S{lr.CADSECTOR}" : string.Empty;
                    }
                    foreach (CGXML.PersonRow pr in fisier.Person)
                    {
                        proprietar = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                        proprietar = proprietar.Replace("|", "");
                        isPhysical = pr.ISPHYSICAL ? "Fizica" : "Juridica";
                        defunct = pr.DEFUNCT ? "DA" : "NU";
                        note = pr.NOTES;
                        cnp = pr.IDCODE;
                        int addressid = pr.ADDRESSID;
                        DataRow[] drAddress = fisier.Tables["ADDRESS"].Select(string.Concat("ADDRESSID=", addressid.ToString()));
                        if (drAddress.Length > 0 && drAddress[0].ItemArray.Length > 1 && !(drAddress[0][1] is DBNull))
                        {
                            if (!string.IsNullOrEmpty(drAddress[0][1].ToString()))
                            {
                                try
                                {
                                    DataRow[] drUAT = dsUAT.Tables[0].Select(string.Concat("ADMINISTRATIVEUNITID='", drAddress[0][1], "'"));
                                    adresa = string.Concat("UAT ", drUAT[0][2]);
                                    if (drAddress[0][3].ToString().ToLower() == "true")
                                    {
                                        DataRow[] drLocality = dsLocality.Tables[0].Select(string.Concat("LOCALITYID='", drAddress[0][2], "'"));
                                        adresa = string.Concat(new object[] { adresa, ", Loc. ", drLocality[0][2], ", " });
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("DISTRICTTYPE") && !string.IsNullOrEmpty(drAddress[0][4].ToString()))
                                        {
                                            DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["DISTRICTTYPE"], "' AND DICTIONARYCODE='DISTRICT'"));
                                            adresa = string.Concat(new object[] { adresa, drDict[0][3], " ", drAddress[0][5] });
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("STREETTYPE") && !string.IsNullOrEmpty(drAddress[0][6].ToString()))
                                        {
                                            DataRow[] drDict = dsStreetType.Tables[0].Select(string.Concat("DICTIONARYITEMCODE='", drAddress[0]["STREETTYPE"], "' AND DICTIONARYCODE='ST'"));
                                            adresa = string.Concat(new object[] { adresa, ", ", drDict[0][3], " ", drAddress[0][7] });
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("POSTALNUMBER") && !string.IsNullOrEmpty(drAddress[0][8].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Nr. ", drAddress[0][8]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("BLOCK") && !string.IsNullOrEmpty(drAddress[0][9].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Bloc ", drAddress[0][9]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("ENTRY") && !string.IsNullOrEmpty(drAddress[0][10].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Sc. ", drAddress[0][10]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("FLOOR") && !string.IsNullOrEmpty(drAddress[0][11].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Et. ", drAddress[0][11]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("APNO") && !string.IsNullOrEmpty(drAddress[0][12].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Ap. ", drAddress[0][12]);
                                        }
                                        if (fisier.Tables["ADDRESS"].Columns.Contains("ZIPCODE") && !string.IsNullOrEmpty(drAddress[0][13].ToString()))
                                        {
                                            adresa = string.Concat(adresa, ", Cod postal ", drAddress[0][13]);
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show(string.Concat(cadgenno, " cu probleme"));
                                }
                            }
                            else
                            {
                                adresa = "Nespecificata";
                            }
                            var row = sheet.CreateRow(rowIndex);

                            row.CreateCell(0).SetCellValue(cadgenno);
                            row.CreateCell(1).SetCellValue(sector);
                            row.CreateCell(2).SetCellValue(ie);
                            row.CreateCell(3).SetCellValue(proprietar);
                            row.CreateCell(4).SetCellValue(isPhysical);
                            row.CreateCell(5).SetCellValue(cnp);
                            row.CreateCell(6).SetCellValue(defunct);
                            row.CreateCell(7).SetCellValue(adresa);
                            row.CreateCell(8).SetCellValue(note);

                            rowIndex++;
                        }
                    }
                }
            }
            //Write the stream data of workbook to the root directory

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            this.Cursor = Cursors.Default;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            RandomListz.Clear();
            AllFileListz.Clear();
            MustFileListz.Clear();
            string raportname = "Lista ID de verificat";
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("ID");
            headerRow.CreateCell(1).SetCellValue("Sector");
            headerRow.CreateCell(2).SetCellValue("IE");
            headerRow.CreateCell(3).SetCellValue("Tip ID");

            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 3));


            int rowIndex = 1;
            Random r = new Random();

            //

            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.TopDirectoryOnly);
            NumericComparer ns = new NumericComparer();
            System.Array.Sort(filez, ns);
            var files = filez.Select(x => new FileInfo(x)).ToArray();
            for (int i = 0; i < (int)files.Length; i++)
            {
                FileInfo fo = files[i];
                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(fo.FullName);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                }


                AllFileListz.Add(files[i].FullName);

                //Populate Raport
                //actions

                foreach (CGXML.LandRow lr in fisier.Land)
                {
                    cadgenno = lr.CADGENNO;
                    sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;
                    ie = lr.E2IDENTIFIER;
                    bool a = TempFileListz.Any(fo.FullName.Contains);
                    bool b = TempFileListz.Contains(fo.FullName);
                    bool c = (TempFileListz.Where(o => string.Equals(fo.FullName, o, StringComparison.OrdinalIgnoreCase)).Any());

                    foreach (CGXML.RegistrationRow lb in fisier.Registration)
                    {
                        if (lb.LBPARTNO == 3)
                        {
                            lbpart = "Sarcini";

                            if (!TempFileListz.Any(fo.FullName.Contains))
                            {
                                var row = sheet.CreateRow(rowIndex);
                                row.CreateCell(0).SetCellValue(cadgenno);
                                row.CreateCell(1).SetCellValue(sector);
                                row.CreateCell(2).SetCellValue(ie);
                                row.CreateCell(3).SetCellValue(lbpart);
                                TempFileListz.Add(fo.FullName);
                                MustFileListz.Add(fo.FullName);
                                RandomListz.Add(fo.FullName);
                                rowIndex++;

                            }
                        }
                    }
                }


            }
            AllFileListz.RemoveAll(item => MustFileListz.Contains(item));
            double roundfilescount = Math.Round(AllFileListz.Count / 10.0);
            //adauga 1 daca valoarea este mai mare de ".0"
            //(FileListSet.Count / 10) + (FileListSet.Count % procent > 0 ? 1 : 0)

            int files2random = Convert.ToInt32(roundfilescount);
            Random = AllFileListz.OrderBy(x => r.Next()).Take(files2random);

            //second part
            //de reparat pt fiecare obiect dint random nu din filelistsets
            //for (int k = 0; k < (int)FileListSet.Count; k++)
            foreach (var RandomVar in Random)
            {

                CGXML fisier = new CGXML();

                try
                {
                    fisier.ReadXml(RandomVar);
                }
                catch (Exception exception)
                {
                    Exception ex = exception;
                    MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, RandomVar }));
                }


                //Populate Raport
                //set vars
                foreach (CGXML.LandRow ffs in fisier.Land)
                {
                    cadgenno = (ffs.CADGENNO);
                    sector = !string.IsNullOrEmpty(ffs.CADSECTOR) ? "S" + ffs.CADSECTOR : string.Empty;
                    ie = ffs.E2IDENTIFIER;
                    var row = sheet.CreateRow(rowIndex);

                    row.CreateCell(0).SetCellValue(cadgenno);
                    row.CreateCell(1).SetCellValue(sector);
                    row.CreateCell(2).SetCellValue(ie);
                    row.CreateCell(3).SetCellValue(lbpart);
                    RandomListz.Add(RandomVar);
                    rowIndex++;
                }
            }

            //Write the stream data of workbook to the root directory

            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls"), FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
            //MessageBox
            DoneMsgBox msg = new DoneMsgBox();
            msg.ShowDialog();

            string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}{sector}_{formattedDate}.xls");

            if (msg.DialogResult == DialogResult.No)
            {
                // Open folder
                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
            }
            else if (msg.DialogResult == DialogResult.Yes)
            {
                // Open file
                System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
            }


            if (checkBox1.Visible != true)
            { checkBox1.Visible = true; }

            TempFileListz.Clear();

        }
*/




        public void compareCgxml_Click(object sender, EventArgs e)
        {
            // compare cgxml data from two folders based on EO2IDENTIFIER
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML-uri inițiale";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                string selectedPath = CostumFolderBrowserDialog.SelectedPath;
                // Check if the folder contains any .cgxml files
                if (!Directory.EnumerateFiles(selectedPath, "*.cgxml", SearchOption.TopDirectoryOnly).Any())
                {
                    // No .cgxml files found, show an error message
                    MessageBox.Show("Nu s-au găsit fișiere .cgxml în dosarul selectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // .cgxml files found
                    CostumFolderBrowserDialogPath = selectedPath;
                }
            }
            else
            {
                return;
            }

            FolderBrowserDialogEx CostumFolderBrowserDialog2 = new FolderBrowserDialogEx();
            string Titlu2 = "Alege Dosarul cu CGXML-uri de comparat";
            CostumFolderBrowserDialog2.Title = Titlu2;
            CostumFolderBrowserDialog2.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr2 = CostumFolderBrowserDialog2.ShowDialog(this);
            if (dr2 == DialogResult.OK)
            {
                string selectedPath2 = CostumFolderBrowserDialog2.SelectedPath;
                // Check if the folder contains any .cgxml files
                if (!Directory.EnumerateFiles(selectedPath2, "*.cgxml", SearchOption.TopDirectoryOnly).Any())
                {
                    // No .cgxml files found, show an error message
                    MessageBox.Show("Nu s-au găsit fișiere .cgxml în dosarul selectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // .cgxml files found
                    CostumFolderBrowserDialogPath = selectedPath2;
                }
            }
            else
            {
                return;
            }

            // excel sheet: ie2identifier, cadgenno, what changes were made for the WHOLE CGXML


        }

        private void compareCgxml_MouseHover(object sender, EventArgs e)
        {

        }

        public string CostumFolderBrowserDialogPath = "";
        private void cgToShpBtn_Click(object sender, EventArgs e) // CGXML -> SHP BTN
        {
            string sectorVal = "";
            string ie = "";
            string imprej = "";
            string noteImobil = "";
            string id = "";
            string person = "";
            string areaCG = "";
            string actAreaCG = "";
            string fullName = "";

            if (imobileCheckbox.Checked || constrCheckbox.Checked)
            {
                FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
                string Titlu = "Alege Dosarul cu CGXML-uri";
                CostumFolderBrowserDialog.Title = Titlu;
                CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
                DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    string selectedPath = CostumFolderBrowserDialog.SelectedPath;
                    // Check if the folder contains any .cgxml files
                    if (!Directory.EnumerateFiles(selectedPath, "*.cgxml", SearchOption.TopDirectoryOnly).Any())
                    {
                        // No .cgxml files found, show an error message
                        MessageBox.Show("Nu s-au găsit fișiere .cgxml în dosarul selectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        // .cgxml files found
                        CostumFolderBrowserDialogPath = selectedPath;
                    }
                }
                else
                {
                    return;
                }

                this.Cursor = Cursors.WaitCursor;
                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath.ToString(), "*.cgxml", SearchOption.TopDirectoryOnly);
                NumericComparer ns = new NumericComparer();
                System.Array.Sort(filez, ns);
                var files = filez.Select(x => new FileInfo(x)).ToArray();
                //initial vars
                string futureFieldName = "ID";
                string futureFieldSector = "Sector";
                string futureFieldIE = "IE";
                string futurePerson = "Proprietari";
                string futureFieldAreaCG = "Sup Mas";
                string futureFieldImprej = "Imprejmuit?";
                string futureFieldTipTeren = "Tip Teren";
                string futureFieldNoteImobil = "Note Imobil";
                string futureFieldTarla = "Nr. Tarla";
                string futureFieldParcela = "Nr. Parcele";
                string futureFieldCategFol = "Categ Fol";
                string futureFieldNrTitlu = "Nr Titlu";
                string futureFieldLegalAreaCG = "Supr Acte";

                int nrCGXML = 0;
                int intr = 0;
                for (int i = 0; i < (int)files.Length; i++)
                {
                    nrCGXML++;
                }
                //Create a future list
                IList<Feature> futuresList = new List<Feature>();
                IList<Feature> buildingFeaturesList = new List<Feature>();
                //loop trough cgxml
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fo = files[i];
                    CGXML fisier = new CGXML();
                    try
                    {
                        fisier.ReadXml(fo.FullName);
                    }
                    catch (Exception exception)
                    {
                        Exception ex = exception;
                        MessageBox.Show(string.Concat(new string[] { "Eroare ", ex.GetType().ToString(), "\n", ex.Message, fo.FullName }));
                    }

                    if (fisier.Points.Count == 0)
                    {
                        continue; // Skip the rest of the loop if no Points are present
                    }

                    if (fisier.Building.Count > 0 && constrCheckbox.Checked)
                    {
                        IGeometryFactory geoFactory = NtsGeometryServices.Instance.CreateGeometryFactory();

                        foreach (CGXML.BuildingRow buildingRow in fisier.Building)
                        {
                            List<Coordinate> buildingCoordList = new List<Coordinate>();

                            foreach (CGXML.PointsRow pr in fisier.Points)
                            {
                                if (pr.BUILDINGID == buildingRow.BUILDINGID)
                                {
                                    buildingCoordList.Add(new Coordinate(pr.X, pr.Y));
                                }
                            }

                            // Ensure the polygon is properly closed
                            if (buildingCoordList.Count >= 3)
                            {
                                // Ensure the polygon is properly closed
                                if (!buildingCoordList.First().Equals(buildingCoordList.Last()))
                                {
                                    buildingCoordList.Add(buildingCoordList.First()); // Close the polygon
                                }

                                Coordinate[] buildingCoords = buildingCoordList.ToArray();
                                var buildingPolygon = geoFactory.CreatePolygon(buildingCoords);

                                // Create attributes table for building
                                var buildingAttributes = new AttributesTable();
                                buildingAttributes.Add("ID", buildingRow.CADGENNO);
                                buildingAttributes.Add("Nr. Constr", "C" + buildingRow.BUILDNO);
                                buildingAttributes.Add("IE", buildingRow.E2IDENTIFIER);
                                buildingAttributes.Add("Destinatie", buildingRow.BUILDINGDESTINATION);
                                buildingAttributes.Add("Etaje", buildingRow.LEVELSNO);
                                buildingAttributes.Add("Supr Mas", Math.Round(buildingRow.MEASUREDAREA, 2).ToString());
                                buildingAttributes.Add("Supr Totala", Math.Round(buildingRow.TOTALAREA, 2).ToString());
                                buildingAttributes.Add("Are Acte?", buildingRow.ISLEGAL ? "Da" : "Nu");
                                buildingAttributes.Add("Note", buildingRow.NOTES);


                                var buildingFeature = new Feature(buildingPolygon, buildingAttributes);
                                buildingFeaturesList.Add(buildingFeature);
                            }
                            else
                            {
                                Console.WriteLine("Error: The coordinates array is empty or has less than 3 points.");
                            }
                        }
                    }
                    else if (fisier.Building.Count == 0 && constrCheckbox.Checked)
                    {
                        MessageBox.Show("Nu s-au găsit construcții în fișierul selectat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (imobileCheckbox.Checked)
                    {
                        //create geometry factory
                        IGeometryFactory geomFactory = NtsGeometryServices.Instance.CreateGeometryFactory();
                        IGeometry[] gr = new IGeometry[nrCGXML];
                        foreach (CGXML.LandRow lr in fisier.Land)
                        {
                            HashSet<string> uniqueTarla = new HashSet<string>();
                            HashSet<string> uniqueParcela = new HashSet<string>();
                            HashSet<string> uniqueCategFol = new HashSet<string>();
                            HashSet<string> uniqueNrTitlu = new HashSet<string>();
                            HashSet<string> uniqueTipTeren = new HashSet<string>();
                            HashSet<string> uniquePerson = new HashSet<string>();

                            var r = 0;
                            var q = 0;
                            Coordinate[] myCoord = new Coordinate[fisier.Points.Count + 1];
                            string[] personArr = new string[fisier.Person.Count];
                            foreach (CGXML.PointsRow pr in fisier.Points)
                            {
                                if (pr.IMMOVABLEID != 9898989)
                                {
                                    if (r < myCoord.Length - 1)
                                    {
                                        myCoord[r++] = new Coordinate(pr.X, pr.Y);
                                    }
                                }
                            }
                            if (r > 0 && myCoord[r - 1] != myCoord[0] && r < myCoord.Length)
                            {
                                myCoord[r] = myCoord[0]; // Safely add closing point
                            }
                            else if (r >= myCoord.Length)
                            {
                                Console.WriteLine("Error: The coordinates array is full, and the polygon cannot be properly closed.");
                            }

                            foreach (CGXML.PersonRow pp in fisier.Person)
                            {
                                fullName = string.Concat(pp.LASTNAME, " ", pp.FIRSTNAME);
                                person = fullName;
                                uniquePerson.Add(fullName);
                            }
                            //create the default table with fields - alternately use DBaseField classes


                            // console the whole table
                            AttributesTable t = new AttributesTable();

                            sectorVal = lr.CADSECTOR;
                            ie = lr.E2IDENTIFIER;
                            imprej = lr.ENCLOSED ? "Da" : "Nu";
                            noteImobil = lr.NOTES;
                            id = lr.CADGENNO;
                            areaCG = lr.MEASUREDAREA.ToString();
                            actAreaCG = lr.PARCELLEGALAREA.ToString();

                            foreach (CGXML.ParcelRow pr in fisier.Parcel)
                            {
                                uniqueTarla.Add(pr.LANDPLOTNO);
                                uniqueParcela.Add(pr.PARCELNO);
                                uniqueCategFol.Add(pr.USECATEGORY);
                                uniqueNrTitlu.Add(pr.TITLENO.ToString());
                                uniqueTipTeren.Add(pr.INTRAVILAN ? "Intravilan" : "Extravilan");

                            }
                            string aggregatedTarla = string.Join("; ", uniqueTarla);
                            string aggregatedParcela = string.Join("; ", uniqueParcela);
                            string aggregatedCategFol = string.Join("; ", uniqueCategFol);
                            string aggregatedNrTitlu = string.Join("; ", uniqueNrTitlu);
                            string aggregatedTipTeren = string.Join("; ", uniqueTipTeren);
                            string aggregatedOwners = string.Join("; ", uniquePerson);

                            t.Add(futureFieldName, id);
                            t.Add(futureFieldSector, sectorVal);
                            t.Add(futureFieldIE, ie);
                            t.Add(futureFieldTipTeren, uniqueTipTeren.Count > 0 ? aggregatedTipTeren : null);
                            t.Add(futureFieldTarla, uniqueTarla.Count > 0 ? aggregatedTarla : null);
                            t.Add(futureFieldParcela, uniqueParcela.Count > 0 ? aggregatedParcela : null);
                            t.Add(futureFieldCategFol, uniqueCategFol.Count > 0 ? aggregatedCategFol : null);
                            t.Add(futureFieldImprej, imprej);
                            t.Add(futureFieldAreaCG, areaCG);
                            t.Add(futureFieldLegalAreaCG, actAreaCG);
                            t.Add(futurePerson, uniquePerson.Count > 0 ? aggregatedOwners : null);
                            t.Add(futureFieldNrTitlu, uniqueNrTitlu.Count > 0 ? aggregatedNrTitlu : null);
                            t.Add(futureFieldNoteImobil, noteImobil);

                            //Geometry 
                            myCoord = myCoord.Where(c => c != null).ToArray();
                            gr[intr] = geomFactory.CreatePolygon(myCoord);
                            futuresList.Add(new Feature(gr[intr], t));
                            intr++;
                        }
                    }
                }
                //Feature list
                string sector = sectorVal == "Fara Sector" ? "" : sectorVal + " ";
                IList<Feature> features = futuresList.OfType<Feature>().ToList();
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");

                // Creating a shapefile for non-building features
                if (features.Any())
                {
                    string shapefile = string.Concat(CostumFolderBrowserDialogPath, "\\", "Imobile ", sector, formattedDate);
                    ShapefileDataWriter writer = new ShapefileDataWriter(shapefile) { Header = ShapefileDataWriter.GetHeader(features[0], features.Count) };
                    writer.Write(features);
                }

                // Creating a shapefile for building features
                if (buildingFeaturesList.Any()) // Check if there are any building features to write
                {
                    string buildingShapefile = string.Concat(CostumFolderBrowserDialogPath, "\\", "Constructii ", sector, formattedDate);
                    ShapefileDataWriter buildingWriter = new ShapefileDataWriter(buildingShapefile)
                    {
                        Header = ShapefileDataWriter.GetHeader(buildingFeaturesList[0], buildingFeaturesList.Count)
                    };
                    buildingWriter.Write(buildingFeaturesList);
                }


                System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Selecteaza tipul de date pe care vrei sa il exporti");
                return;
            }
        }


        private void cgToShpBtn_MouseHover(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string raportname = "Validare Dosare-Fisiere";
            //Create new Excel Workbook
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();

            //Create new Excel Sheet
            var sheet = hssfworkbook.CreateSheet(raportname);

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "OCPI MH";
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Export data from xml to xls using NPOI";
            hssfworkbook.SummaryInformation = si;


            //Create a header row
            string UAT = "Padina";
            string Sector_Letter = "S";
            string Sector_NR = "34";
            var headerRow = sheet.CreateRow(1);
            sheet.CreateRow(0).CreateCell(0).SetCellValue("UAT " + UAT);
            sheet.CreateRow(0).CreateCell(1).SetCellValue(string.Concat(Sector_Letter + Sector_NR));
            headerRow.CreateCell(0).SetCellValue("Dosar");
            headerRow.CreateCell(1).SetCellValue("Rezultat");


            //(Optional) freeze the header row so it is not scrolled
            //sheet.CreateFreezePane(0, 1, 0, 1);



            //Auto Filter
            //sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 8));


            DataSet dsUAT = new DataSet();
            DataSet dsLocality = new DataSet();
            DataSet dsStreetType = new DataSet();
            dsUAT.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Admin.xml"));
            dsLocality.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Locality.xml"));
            dsStreetType.ReadXml(string.Concat(Application.StartupPath.ToString(), "\\ProgramData\\Dictionary.xml"));
            //

            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML-uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;

            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                //var
                string end1 = "_DATE_teren";
                string end2 = "Memoriu_tehnic";
                string end3 = "_Registru";
                string end4 = "_Opis";
                string end5 = "_Planuri_Cadastrale";
                string end6 = "shp";
                string end7 = "DXF";

                // //rootfolder
                // bool rootfolder;
                // if(Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                // { rootfolder = true; }
                // else { rootfolder = false; }
                // //cgxml
                // bool cgxmlfolder;
                // if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                // { cgxmlfolder = true; }
                // else { cgxmlfolder = false; }
                // //sector cgxml
                // bool sectorcgxml;
                // if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                // { sectorcgxml = true; }
                // else { sectorcgxml = false; }
                //Date Teren
                bool DateTerenFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end1))
                { DateTerenFolder = true; }
                else { DateTerenFolder = false; }
                //Memoriu
                bool MemoriuTehnicFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end1 + "\\" + end2))
                { MemoriuTehnicFolder = true; }
                else { MemoriuTehnicFolder = false; }
                //Opis
                bool OpisFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end4))
                { OpisFolder = true; }
                else { OpisFolder = false; }
                //Sector Opis
                // bool OpisSector;
                // if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end4 + "\\" + Sector_Letter+Sector_NR))
                // { OpisSector = true; }
                // else { OpisSector = false; }
                //Planuri Cadastrale
                bool PlanCadFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end5))
                { PlanCadFolder = true; }
                else { PlanCadFolder = false; }
                //Shp Plan
                bool SHPFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end5 + "\\" + end6))
                { SHPFolder = true; }
                else { SHPFolder = false; }
                //PDF
                //Dxf Plan
                bool DXFFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end5 + "\\" + end7))
                { DXFFolder = true; }
                else { DXFFolder = false; }
                //PDF
                // bool PDFFOLDER;
                // if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                // { PDFFOLDER = true; }
                // else { PDFFOLDER = false; }
                //Reg
                bool RegistruFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end3))
                { RegistruFolder = true; }
                else { RegistruFolder = false; }
                //Reg sector
                bool RegistruSectorFolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end3 + "\\" + Sector_Letter + Sector_NR))
                { RegistruSectorFolder = true; }
                else { RegistruSectorFolder = false; }
                string str1 = string.Concat(CostumFolderBrowserDialog.SelectedPath + "\\" + end3 + "\\" + Sector_Letter + Sector_NR);
                string str2 = string.Concat(UAT + end3);
                string str3 = string.Concat(Sector_Letter + Sector_NR);
                string str4 = string.Concat(UAT + end4);
                string test = UAT + end1;

                sheet.CreateRow(2).CreateCell(0).SetCellValue(str1);
                sheet.CreateRow(2).CreateCell(1).SetCellValue(DateTerenFolder);
                sheet.CreateRow(3).CreateCell(0).SetCellValue(end2);
                sheet.CreateRow(3).CreateCell(1).SetCellValue(MemoriuTehnicFolder);
                sheet.CreateRow(4).CreateCell(0).SetCellValue(str2);
                sheet.CreateRow(4).CreateCell(1).SetCellValue(RegistruFolder);
                sheet.CreateRow(5).CreateCell(0).SetCellValue(str3);
                sheet.CreateRow(5).CreateCell(1).SetCellValue(RegistruSectorFolder);
                sheet.CreateRow(6).CreateCell(0).SetCellValue(str4);
                sheet.CreateRow(6).CreateCell(1).SetCellValue(OpisFolder);
                sheet.CreateRow(7).CreateCell(0).SetCellValue(UAT + end5);
                sheet.CreateRow(7).CreateCell(1).SetCellValue(PlanCadFolder);
                sheet.CreateRow(8).CreateCell(0).SetCellValue(end6);
                sheet.CreateRow(8).CreateCell(1).SetCellValue(SHPFolder);
                sheet.CreateRow(9).CreateCell(0).SetCellValue(end7);
                sheet.CreateRow(9).CreateCell(1).SetCellValue(DXFFolder);

                //Write the stream data of workbook to the root directory
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
                FileStream file = new FileStream(Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}_{formattedDate}.xls"), FileMode.Create);
                hssfworkbook.Write(file);
                file.Close();
                //MessageBox
                DoneMsgBox msg = new DoneMsgBox();
                msg.ShowDialog();

                string filePath = Path.Combine(CostumFolderBrowserDialogPath, $"{raportname}_{formattedDate}.xls");

                if (msg.DialogResult == DialogResult.No)
                {
                    // Open folder
                    System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
                }
                else if (msg.DialogResult == DialogResult.Yes)
                {
                    // Open file
                    System.Diagnostics.Process.Start("explorer.exe", $"\"{filePath}\"");
                }

            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            eVisible(false);
            if (backgroundImageLogo.Visible == false)
            {
                backgroundImageLogo.Visible = true;
            }
        }
        #endregion


        //

        public class FileNameFixer
        {
            public FileNameFixer()
            {
                StringToRemove = "_";
                StringReplacement = "";


            }
            public void FixAll(string directory)
            {
                IEnumerable<string> files = Directory.EnumerateFiles(directory);
                foreach (string file in files)
                {
                    try
                    {
                        FileInfo info = new FileInfo(file);
                        if (!info.IsReadOnly && !info.Attributes.HasFlag(FileAttributes.System))
                        {
                            string destFileName = GetNewFile(file);
                            info.MoveTo(destFileName);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.Write(ex.Message);
                    }
                }
            }

            private string GetNewFile(string file)
            {
                string nameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                if (nameWithoutExtension != null && nameWithoutExtension.Length > 1)
                {
                    return Path.Combine(Path.GetDirectoryName(file),
                        file.Replace(StringToRemove, StringReplacement));
                }
                return file;
            }

            public string StringToRemove { get; set; }

            public string StringReplacement { get; set; }
        }

        private void button7_Click(object sender, EventArgs e)

        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu Titluri'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;

            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                FileNameFixer fixer = new FileNameFixer();
                fixer.StringReplacement = String.Empty;
                fixer.StringToRemove = filePrefix.Text;
                fixer.FixAll(CostumFolderBrowserDialog.SelectedPath);
            }
        }

        public void CoordinatesPairsStereo(ref ArrayList x, ref ArrayList y, int IMMOVABLEID, int BUILDINGID)
        {
            CGXML fisier = new CGXML();
            x = new ArrayList();
            y = new ArrayList();

            if (BUILDINGID >= 0)
            {
                DataRow[] dataRowArray = fisier.Points.Select(string.Concat("BUILDINGID=", Conversions.ToString(BUILDINGID)));
                for (int i = 0; i < checked((int)dataRowArray.Length); i = checked(i + 1))
                {
                    CGXML.PointsRow pointsRow = (CGXML.PointsRow)dataRowArray[i];
                    x.Add(Math.Round(pointsRow.X, 3));
                    y.Add(Math.Round(pointsRow.Y, 3));
                }
            }
            else
            {
                DataRow[] dataRowArray1 = fisier.Points.Select(string.Concat("IMMOVABLEID=", Conversions.ToString(IMMOVABLEID)));
                for (int j = 0; j < checked((int)dataRowArray1.Length); j = checked(j + 1))
                {
                    CGXML.PointsRow pointsRow1 = (CGXML.PointsRow)dataRowArray1[j];
                    x.Add(Math.Round(pointsRow1.X, 3));
                    y.Add(Math.Round(pointsRow1.Y, 3));
                }
            }
        }
        

        private void imobileCheckbox_Click(object sender, EventArgs e)
        {
            if (imobileCheckbox.Checked == true)
            {
                imobileCheckbox.ForeColor = System.Drawing.Color.FromArgb(0, 130, 237);
            }
            else
            {
                imobileCheckbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void constrCheckbox_Click(object sender, EventArgs e)
        {
            if (constrCheckbox.Checked == true)
            {
                constrCheckbox.ForeColor = System.Drawing.Color.FromArgb(0, 130, 237);
            }
            else
            {
                constrCheckbox.ForeColor = System.Drawing.Color.Black;
            }
        }

        //listbox
        public object lb_item = null;

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                listBox1.Items.Add(file);
            Point point = listBox1.PointToClient(new Point(e.X, e.Y));
            int index = this.listBox1.IndexFromPoint(point);
            if (index < 0) index = this.listBox1.Items.Count - 1;
            object data = e.Data.GetData(typeof(DateTime));
            this.listBox1.Items.Remove(data);
            this.listBox1.Items.Insert(index, data);
            lb_item = null;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            if (lb_item != null)
            {
                listBox1.Items.Add(lb_item);
                lb_item = null;
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.listBox1.DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Move);
            lb_item = null;

            if (listBox1.Items.Count == 0)
            {
                return;
            }

            int index = listBox1.IndexFromPoint(e.X, e.Y);
            string s = listBox1.Items[index].ToString();
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            lb_item = lb.SelectedItem;
            lb.Items.Remove(lb.SelectedItem);
        }
    }
}
