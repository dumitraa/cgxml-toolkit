using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//Added
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.SS.UserModel;
using NPOI.POIFS.FileSystem;
using NPOI.SS.Util;
using GeoAPI;
using GeoAPI.Geometries;
using NetTopologySuite;
using NetTopologySuite.IO;
using NetTopologySuite.Shape;
using NetTopologySuite.IO.ShapeFile;
using NetTopologySuite.Features;
using DaveChambers.FolderBrowserDialogEx;
using nc;


namespace UtilitatiCGXML
{
    public partial class CustomControl0 : UserControl
    {
        private void tEnabled(bool state)
        {
            checkBox1.Enabled = state;
            raportParcelaBtn.Enabled = state;
            raportConstructiiBtn.Enabled = state;
            raportSarciniBtn.Enabled = state;
            raportTipInscrieriBtn.Enabled = state;
            raportProprietariBtn.Enabled = state;
            button6.Enabled = state;
        }
        private List<string> AllFileListz = new List<string>();
        private List<string> MustFileListz = new List<string>();
        private List<string> RandomListz = new List<string>();
        private List<string> TempFileListz = new List<string>();
        private IEnumerable<string> Random = new List<string>();
        //public DirectoryInfo CostumFolderBrowserDialogPath = new DirectoryInfo("C:\\Temp");
        private string CostumFolderBrowserDialogPath = "";

        //Temp Strings
        public string cadgenno = "";
        public string sector = "";
        public string ie = "";
        public string measarea = "";
        public string parcellegalarea = "";
        public string dif = "";
        public string titleno = "";
        public string landplotno = "";
        public string parcelno = "";
        public string parcelarea = "";
        public string cat = "";
        public string intra = "";
        public string note = "";
        public string notes = "";
        public string nrtopo = "";
        public string nrcf = "";
        public string nrcad = "";
        public string enclosed = "";
        public string proprietar = "";
        public string pnotes = "";
        public string buildingid = "";
        public string measuredarea = "";
        public string destinatie = "";
        public string legalbuilding = "";
        public string bnotes = "";
        public string BLA = "";
        public string nivel = "";
        public string legalarea = "";
        public string regtype = "";
        public string sup = "";
        public string deedtype = "";
        public string adresa = "";
        public string UAT_land = "";
        public string defunct = "";
        public string cnp = "";
        public string lbpart = "";
        //

        public CustomControl0()
        {
            InitializeComponent();
            StylePanelAndButtons();
            tEnabled(false);
        }
        #region Designer Components
        private void label1_Click(object sender, EventArgs e)
        {
            if (raportContentLabel.Visible == true)
            {
                raportContentLabel.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (backgroundImageLogo.Visible == false)
            {
                backgroundImageLogo.Visible = true;
            }
        }

        private void raportParcelaBtn_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }

            if (tableLayoutPanelParcele.Visible == false)
            {
                tableLayoutPanelParcele.Visible = true;
            }/*
            tableLayoutPanelParcele.ColumnCount = 4;
            tableLayoutPanelParcele.RowCount = 5;
            tableLayoutPanelParcele.Size.Height = 645;
            tableLayoutPanelParcele.Size.Width = 375;*/
        }

        private void raportConstructiiBtn_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == false)
            {
                tableLayoutPanelConstructii.Visible = true;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }
        }

        private void raportSarciniBtn_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }

            if (tableLayoutPanel3.Visible == false)
            {
                tableLayoutPanel3.Visible = true;
            }
        }

        private void raportTipInscrieriBtn_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }

            if (tableLayoutPanel4.Visible == false)
            {
                tableLayoutPanel4.Visible = true;
            }
        }

        private void raportProprietariBtn_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel6.Visible == true)
            {
                tableLayoutPanel6.Visible = false;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }

            if (tableLayoutPanel5.Visible == false)
            {
                tableLayoutPanel5.Visible = true;
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (backgroundImageLogo.Visible == true)
            {
                backgroundImageLogo.Visible = false;
            }

            if (tableLayoutPanelParcele.Visible == true)
            {
                tableLayoutPanelParcele.Visible = false;
            }

            if (tableLayoutPanelConstructii.Visible == true)
            {
                tableLayoutPanelConstructii.Visible = false;
            }

            if (tableLayoutPanel3.Visible == true)
            {
                tableLayoutPanel3.Visible = false;
            }

            if (tableLayoutPanel4.Visible == true)
            {
                tableLayoutPanel4.Visible = false;
            }

            if (tableLayoutPanel5.Visible == true)
            {
                tableLayoutPanel5.Visible = false;
            }

            if (raportContentLabel.Visible == false)
            {
                raportContentLabel.Visible = true;
            }

            if (tableLayoutPanel6.Visible == false)
            {
                tableLayoutPanel6.Visible = true;
            }
        }

        #endregion

        //Buttons
        #region Buttons
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
            headerRow.CreateCell(3).SetCellValue("Nr CAD");
            headerRow.CreateCell(4).SetCellValue("Nr CF");
            headerRow.CreateCell(5).SetCellValue("Nr TOPO");
            headerRow.CreateCell(6).SetCellValue("Proprietari");
            headerRow.CreateCell(7).SetCellValue("Suprafata Masurata");
            headerRow.CreateCell(8).SetCellValue("Suprafata din Acte");
            headerRow.CreateCell(9).SetCellValue("Diferenta de suprafata");
            headerRow.CreateCell(10).SetCellValue("Nr Titlu");
            headerRow.CreateCell(11).SetCellValue("Nr Tarla");
            headerRow.CreateCell(12).SetCellValue("Nr Parcela");
            headerRow.CreateCell(13).SetCellValue("Suprafata Parcela");
            headerRow.CreateCell(14).SetCellValue("Categorie de folosinta");
            headerRow.CreateCell(15).SetCellValue("Imprejmuit");
            headerRow.CreateCell(16).SetCellValue("Tip teren");
            headerRow.CreateCell(17).SetCellValue("Note Imobil");
            headerRow.CreateCell(18).SetCellValue("Note Parcela");
            headerRow.CreateCell(19).SetCellValue("Note Proprietar");
            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);


            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 19));


            int rowIndex = 1;


            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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
                                row.CreateCell(3).SetCellValue(nrcad);
                                row.CreateCell(4).SetCellValue(nrcf);
                                row.CreateCell(5).SetCellValue(nrtopo);
                                row.CreateCell(6).SetCellValue(proprietar);
                                row.CreateCell(7).SetCellValue(measarea);
                                row.CreateCell(8).SetCellValue(parcellegalarea);
                                row.CreateCell(9).SetCellValue(dif);
                                row.CreateCell(10).SetCellValue(titleno);
                                row.CreateCell(11).SetCellValue(landplotno);
                                row.CreateCell(12).SetCellValue(parcelno);
                                row.CreateCell(13).SetCellValue(parcelarea);
                                row.CreateCell(14).SetCellValue(cat);
                                row.CreateCell(15).SetCellValue(enclosed);
                                row.CreateCell(16).SetCellValue(intra);
                                row.CreateCell(17).SetCellValue(note);
                                row.CreateCell(18).SetCellValue(notes);
                                row.CreateCell(19).SetCellValue(pnotes);

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
                            row.CreateCell(3).SetCellValue(nrcad);
                            row.CreateCell(4).SetCellValue(nrcf);
                            row.CreateCell(5).SetCellValue(nrtopo);
                            row.CreateCell(6).SetCellValue(proprietar);
                            row.CreateCell(7).SetCellValue(measarea);
                            row.CreateCell(8).SetCellValue(parcellegalarea);
                            row.CreateCell(9).SetCellValue(dif);
                            row.CreateCell(10).SetCellValue(titleno);
                            row.CreateCell(11).SetCellValue(landplotno);
                            row.CreateCell(12).SetCellValue(parcelno);
                            row.CreateCell(13).SetCellValue(parcelarea);
                            row.CreateCell(14).SetCellValue(cat);
                            row.CreateCell(15).SetCellValue(enclosed);
                            row.CreateCell(16).SetCellValue(intra);
                            row.CreateCell(17).SetCellValue(note);
                            row.CreateCell(18).SetCellValue(notes);
                            row.CreateCell(19).SetCellValue(pnotes);

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

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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
                            if (lb.LBPARTNO != 3)
                                ;
                            else
                            {
                                lbpart = "DA";
                                foreach (CGXML.LandRow lr in fisier.Land)
                                {
                                    cadgenno = lr.CADGENNO;
                                    sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? "S" + lr.CADSECTOR : string.Empty;                                    
                                    ie = lr.E2IDENTIFIER;

                                    var row = sheet.CreateRow(rowIndex);

                                    row.CreateCell(0).SetCellValue(cadgenno);
                                    row.CreateCell(1).SetCellValue(sector);
                                    row.CreateCell(2).SetCellValue(ie);
                                    row.CreateCell(3).SetCellValue(lbpart);

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

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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
                                    if(lm.DEEDTYPE == "ACT_NOTARIAL")
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
            headerRow.CreateCell(4).SetCellValue("CNP/CUI");
            headerRow.CreateCell(5).SetCellValue("Defunct");
            headerRow.CreateCell(6).SetCellValue("Adresa");
            headerRow.CreateCell(7).SetCellValue("Note");

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
            
                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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

                            if (drAddress.Length > 0 && drAddress[0].ItemArray.Length > 1) {
                                // Safely attempt to access the data
                                var administrativeUnitId = drAddress[0][1].ToString();

                                DataRow[] uatRows = dsUAT.Tables[0].Select($"ADMINISTRATIVEUNITID='{administrativeUnitId}'");
                                
                                if (uatRows.Length > 0 && uatRows[0].ItemArray.Length > 2) {
                                    UAT_land = uatRows[0][2].ToString();
                                    UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                                } else {
                                    Console.WriteLine($"No rows found in dsUAT.Tables[0] for ADMINISTRATIVEUNITID='{administrativeUnitId}', or column index 2 is missing.");
                                }
                            } else {
                                    Console.WriteLine($"No rows found for ADDRESSID={aDDRESSID} in 'ADDRESS' table, or the row does not contain enough data.");
                            }

                            string sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? $"S{lr.CADSECTOR}" : string.Empty;
                            }
                            foreach (CGXML.PersonRow pr in fisier.Person)
                            {
                                proprietar = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                                proprietar = proprietar.Replace("|", "");
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
                                    row.CreateCell(4).SetCellValue(cnp);
                                    row.CreateCell(5).SetCellValue(defunct);
                                    row.CreateCell(6).SetCellValue(adresa);
                                    row.CreateCell(7).SetCellValue(note);

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

                        if (drAddress.Length > 0 && drAddress[0].ItemArray.Length > 1) {
                            // Safely attempt to access the data
                            var administrativeUnitId = drAddress[0][1].ToString();

                            DataRow[] uatRows = dsUAT.Tables[0].Select($"ADMINISTRATIVEUNITID='{administrativeUnitId}'");
                            
                            if (uatRows.Length > 0 && uatRows[0].ItemArray.Length > 2) {
                                UAT_land = uatRows[0][2].ToString();
                                UAT_land = UAT_land.Normalize(NormalizationForm.FormD);
                            } else {
                                Console.WriteLine($"No rows found in dsUAT.Tables[0] for ADMINISTRATIVEUNITID='{administrativeUnitId}', or column index 2 is missing.");
                            }
                        } else {
                                Console.WriteLine($"No rows found for ADDRESSID={aDDRESSID} in 'ADDRESS' table, or the row does not contain enough data.");
                        }

                        string sector = !string.IsNullOrEmpty(lr.CADSECTOR) ? $"S{lr.CADSECTOR}" : string.Empty;
                        }
                        foreach (CGXML.PersonRow pr in fisier.Person)
                        {
                            proprietar = string.Concat(pr.LASTNAME, " ", pr.FIRSTNAME);
                            proprietar = proprietar.Replace("|", "");
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
                            row.CreateCell(4).SetCellValue(cnp);
                            row.CreateCell(5).SetCellValue(defunct);
                            row.CreateCell(6).SetCellValue(adresa);
                            row.CreateCell(7).SetCellValue(note);

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

                string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath, "*.cgxml", SearchOption.AllDirectories);
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

        private void caleFisiereCgxmlBtn_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Visible == true)
            {
                this.checkBox1.Visible = false;
            }
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML-uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                tEnabled(true);
                CostumFolderBrowserDialogPath = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        #endregion

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                checkBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //browse
            FileInfo[] files = (new DirectoryInfo(CostumFolderBrowserDialogPath)).GetFiles("*.cgxml", SearchOption.TopDirectoryOnly);       
            //initial vars
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            string shapefile = string.Concat(CostumFolderBrowserDialogPath, "\\", "Imobile" + formattedDate);
            string futureFieldName = "ID";
            string futureFieldAreaCG = "Suprafata";
            string futureFieldLegalCG = "Suprafata Acte";
            string futurePerson = "Proprietar";
            int nrCGXML = 0;
            for (int i = 0; i < (int)files.Length; i++)
            {
                nrCGXML++;
            }
            
            Feature[] poop = new Feature[nrCGXML];
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

                //create geometry factory
                IGeometryFactory geomFactory = NtsGeometryServices.Instance.CreateGeometryFactory();
                foreach (CGXML.LandRow lr in fisier.Land)
                {
                    var r = 0;
                    string Person = "";
                    Coordinate[] myCoord = new Coordinate[fisier.Points.Count];
                    foreach (CGXML.PointsRow pr in fisier.Points)
                    {
                        myCoord[r] = new Coordinate(pr.X, pr.Y);
                        r++;
                    }
                    foreach(CGXML.PersonRow pp in fisier.Person)
                    {
                        if(pp.PERSONID == 1)
                        {
                            Person = string.Concat(pp.FIRSTNAME, " ", pp.LASTNAME);
                        }
                    }
                    if (myCoord[0] != myCoord.Last())
                    {
                        myCoord[i++] = myCoord[0];
                    }
                    //create the default table with fields - alternately use DBaseField classes
                    AttributesTable t = new AttributesTable();
                    t.Add(futureFieldName, lr.CADGENNO);
                    t.Add(futureFieldAreaCG, lr.MEASUREDAREA);
                    t.Add(futureFieldLegalCG , lr.PARCELLEGALAREA);
                    t.Add(futurePerson, Person);
                    //Geometry 
                    if (myCoord[0] != myCoord.Last())
                    {
                        myCoord[i++] = myCoord[0];
                    }
                    IGeometry g = geomFactory.CreatePolygon(myCoord);
                    var x = 0;
                    poop[x] = new Feature(g, t);
                    x++;
                }
            }
            //Feature list
            IList<Feature> features = poop.OfType<Feature>().ToList();
            ShapefileDataWriter writer = new ShapefileDataWriter(shapefile) { Header = ShapefileDataWriter.GetHeader(features[0], features.Count) };
            writer.Write(features);

            System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "Puncte";
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
            headerRow.CreateCell(0).SetCellValue("X");
            headerRow.CreateCell(1).SetCellValue("Y");
            headerRow.CreateCell(2).SetCellValue("Nr Pct");
            headerRow.CreateCell(3).SetCellValue("ID");
            //(Optional) freeze the header row so it is not scrolled
            sheet.CreateFreezePane(0, 1, 0, 1);
            
            //Auto Filter

            sheet.SetAutoFilter(new CellRangeAddress(0, 0, 0, 19));

            int rowIndex = 1;

            FileInfo[] files = (new DirectoryInfo(CostumFolderBrowserDialogPath)).GetFiles("*.cgxml", SearchOption.TopDirectoryOnly);
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
                //actions
                foreach (CGXML.LandRow lr in fisier.Land)
                {
                    int ID = Int32.Parse(lr.CADGENNO);
                    foreach (CGXML.PointsRow pr in fisier.Points)
                    {
                        var row = sheet.CreateRow(rowIndex);
                        row.CreateCell(0).SetCellValue(pr.X);
                        row.CreateCell(1).SetCellValue(pr.Y);
                        row.CreateCell(2).SetCellValue(pr.POINTID);
                        row.CreateCell(3).SetCellValue(ID);

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
        }
    }
}
