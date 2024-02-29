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

namespace UtilitatiCGXML
{
    public partial class CostumControl1 : UserControl
    {
        public string FilePath1 = "";
        public string FilePath2 = "";
        public string FilePath3 = "";
        public string FilePath4 = "";
        public string FilePath5 = "";
        public string FilePath6 = "";
        public string FilePath7 = "";

        public string FolderPath1 = "";
        public string FolderPath2 = "";
        public string FolderPath3 = "";
        public string FolderPath4 = "";
        public string FolderPath5 = "";
        public string FolderPath6 = "";
        public string FolderPath7 = "";
        public bool MultiplePDF;
        public bool PathFolder1;
        public bool PathFolder2;
        public bool PathFolder3;
        public bool PathFolder4;
        public bool PathFolder5;
        public bool PathFolder6;
        public bool PathFolder7;

        private void eVisible(bool state)
        {
            //textBox
            textBox1.Visible = state;
            textBox2.Visible = state;
            textBox3.Visible = state;
            textBox4.Visible = state;
            textBox5.Visible = state;
            textBox6.Visible = state;
            textBox7.Visible = state;
            textBox8.Visible = state;
            filePrefix.Visible = state;
            //button
            button7.Visible = state;
            button10.Visible = state;
            button11.Visible = state;
            button12.Visible = state;
            button13.Visible = state;
            button14.Visible = state;
            button15.Visible = state;
            button16.Visible = state;
            button17.Visible = state;
            button18.Visible = state;
            button19.Visible = state;
            button20.Visible = state;
            button21.Visible = state;
            button22.Visible = state;
            button23.Visible = state;
            button24.Visible = state;
            button25.Visible = state;
            button26.Visible = state;
            //comboBox
            comboBox1.Visible = state;
            //label
            label2.Visible = state;
            label3.Visible = state;
            label4.Visible = state;
            label5.Visible = state;
            //pictureBox
            pictureBox1.Visible = state;
            //checkBox
            checkBox1.Visible = state;
        }
        public CostumControl1()
        {
            InitializeComponent();
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
            if (label2.Visible == true)
            {
                label2.Visible = false;
            }
            if (label3.Visible == true)
            {
                label3.Visible = false;
            }
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eVisible(false);
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
            }
            if (filePrefix.Visible == false)
            {
                filePrefix.Visible = true;
            }
            if (button7.Visible == false)
            {
                button7.Visible = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }
        class Verificator
        {
            public int icadgenno { get; set; }
            public string sector { get; set; }
            public string ie { get; set; }
            public string lbparno { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eVisible(false);
            button25.Visible = true;
            button26.Visible = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }
        public string CostumFolderBrowserDialogPath = "";
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Visible != true)
            {
                this.listBox1.Visible = true;
            }
            string sectorVal = "";
            string ie = "";
            string imprej = "";
            string noteImobil = "";
            string id = "";
            string person = "";
            string areaCG = "";
            string actAreaCG = "";
            string fullName = "";

            //browse
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                CostumFolderBrowserDialogPath = CostumFolderBrowserDialog.SelectedPath;
            }
            string[] filez = Directory.GetFiles(CostumFolderBrowserDialogPath.ToString(), "*.cgxml", SearchOption.AllDirectories);
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
                    Coordinate[] myCoord = new Coordinate[fisier.Points.Count+1];
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

                    foreach(CGXML.ParcelRow pr in fisier.Parcel)
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
            //Feature list
            string sector = sectorVal == "Fara Sector" ? "" : sectorVal + " ";
            IList<Feature> features = futuresList.OfType<Feature>().ToList();
            DateTime now = DateTime.Now;
            string formattedDate = now.ToString("yyyy-MM-dd_HH-mm-ss");
            string shapefile = string.Concat(CostumFolderBrowserDialogPath, "\\", "Imobile ", sector, formattedDate);
            ShapefileDataWriter writer = new ShapefileDataWriter(shapefile) { Header = ShapefileDataWriter.GetHeader(features[0], features.Count) };
            writer.Write(features);

            System.Diagnostics.Process.Start("explorer.exe", CostumFolderBrowserDialogPath);
        }
        private void button3_MouseHover(object sender, EventArgs e)
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
            sheet.CreateRow(0).CreateCell(1).SetCellValue(string.Concat(Sector_Letter+Sector_NR));
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
            string Titlu = "Alege Dosarul cu CGXML'uri";
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

                //rootfolder
                bool rootfolder;
                if(Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                { rootfolder = true; }
                else { rootfolder = false; }
                //cgxml
                bool cgxmlfolder;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                { cgxmlfolder = true; }
                else { cgxmlfolder = false; }
                //sector cgxml
                bool sectorcgxml;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                { sectorcgxml = true; }
                else { sectorcgxml = false; }
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
                bool OpisSector;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath + "\\" + end4 + "\\" + Sector_Letter+Sector_NR))
                { OpisSector = true; }
                else { OpisSector = false; }
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
                bool PDFFOLDER;
                if (Directory.Exists(CostumFolderBrowserDialog.SelectedPath))
                { PDFFOLDER = true; }
                else { PDFFOLDER = false; }
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
                sheet.CreateRow(7).CreateCell(0).SetCellValue(UAT+end5);
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
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
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

        private void button10_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder1 = false;
            textBox1.Text = filePath;
            FilePath1 = filePath;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder2 = false;
            textBox2.Text = filePath;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder3 = false;
            textBox3.Text = filePath;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder4 = false;
            textBox4.Text = filePath;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder5 = false;
            textBox5.Text = filePath;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "fisiere pdf (*.pdf)|*.pdf|Orice fisier (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder6 = false;
            textBox6.Text = filePath;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.InitialDirectory = "F:\\a\\";
                openFileDialog.Filter = "Fisier PDF (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            PathFolder7 = false;
            textBox7.Text = filePath;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder1 = true;
                textBox1.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder2 = true;
                textBox2.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder3 = true;
                textBox3.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder4 = true;
                textBox4.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder5 = true;
                textBox5.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder6 = true;
                textBox6.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx CostumFolderBrowserDialog = new FolderBrowserDialogEx();
            string Titlu = "Alege Dosarul cu CGXML'uri";
            CostumFolderBrowserDialog.Title = Titlu;
            CostumFolderBrowserDialog.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = CostumFolderBrowserDialog.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                PathFolder7 = true;
                textBox7.Text = CostumFolderBrowserDialog.SelectedPath;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (MultiplePDF == false)
            {
                const string pdfkPath = "Extras\\pdftk.exe";

                var paths = new List<string>();

                paths.Add(string.Concat("\"" + textBox1.Text + "\""));
                paths.Add(string.Concat("\"" + textBox2.Text + "\""));
                if(!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    paths.Add(string.Concat("\"" + textBox3.Text + "\""));
                }
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    paths.Add(string.Concat("\"" + textBox4.Text + "\""));
                }
                if (!string.IsNullOrWhiteSpace(textBox5.Text))
                {
                    paths.Add(string.Concat("\"" + textBox5.Text + "\""));
                }
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    paths.Add(string.Concat("\"" + textBox6.Text + "\""));
                }
                    string output = string.Concat("\"" + textBox7.Text + "\"");

                var cmd = String.Join(" ", paths) + " cat output " + output;

                Process p = new Process();
                p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                p.StartInfo.FileName = pdfkPath;
                p.StartInfo.Arguments = cmd;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.WaitForExit();
            }
            if(MultiplePDF == true && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                const string pdfkPath = "Extras\\pdftk.exe";

                var paths = new List<string>();

                string input = (string.Concat("\"" + textBox1.Text + "\\" + "*.pdf" + "\""));
                string output = string.Concat("\"" + textBox7.Text + "\\" + "test.pdf" + "\"");

                var cmd = input + " cat output " + output;

                Process p = new Process();
                p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                p.StartInfo.FileName = pdfkPath;
                p.StartInfo.Arguments = cmd;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.WaitForExit();
            }
            else
            {
                List<string> filenames = new List<string>();
                FileInfo[] files = (new DirectoryInfo(textBox1.Text)).GetFiles("*.pdf", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < (int)files.Length; i++)
                {
                    filenames.Add(files[i].Name);
                }
                    foreach (var filez in filenames)
                    {
                        string fo2 = filez;
                        const string pdfkPath = "Extras\\pdftk.exe";

                        var paths = new List<string>();

                        //paths.Add(textBox1.Text);
                        if (PathFolder1 == false)
                        {
                            paths.Add(string.Concat("\"" + textBox1.Text + "\""));
                        }
                        if (PathFolder1 == true)
                        {
                            paths.Add(string.Concat("\"", textBox1.Text, "\\", fo2, "\""));
                        }
                        if (PathFolder2 == false)
                        {
                            paths.Add(string.Concat("\"" + textBox2.Text + "\""));
                        }
                        else
                        {
                            paths.Add(string.Concat("\"", textBox2.Text, "\\", fo2, "\""));
                        }
                    //paths.Add(@textBox3.Text);
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        if (PathFolder3 == false)
                        {
                            paths.Add(string.Concat("\"", textBox3.Text, "\""));
                        }
                        else
                        {
                            paths.Add(string.Concat("\"", textBox3.Text, "\\", fo2, "\""));
                        }
                    }
                    //paths.Add(@textBox4.Text);
                    if (!string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        if (PathFolder4 == false)
                        {
                            paths.Add(string.Concat("\"", textBox4.Text, "\""));
                        }
                        else
                        {
                            paths.Add(string.Concat("\"", textBox4.Text, "\\", fo2, "\""));
                        }
                    }
                    //paths.Add(@textBox5.Text);
                    if (!string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        if (PathFolder5 == false)
                        {
                            paths.Add(string.Concat("\"", textBox5.Text, "\""));
                        }
                        else
                        {
                            paths.Add(string.Concat("\"", textBox5.Text, "\\", fo2, "\""));
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        //paths.Add(@textBox6.Text);
                        if (PathFolder6 == false)
                        {
                            paths.Add(string.Concat("\"", textBox6.Text, "\""));
                        }
                        else
                        {
                            paths.Add(string.Concat("\"", textBox6.Text, "\\", fo2, "\""));
                        }
                    }

                        string output = string.Concat("\"", textBox7.Text, "\\", fo2, "\"");
                        
                        var cmd = String.Join(" ", paths) + " cat output " + output;
                        

                        Process p = new Process();
                        
                        p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
                        p.StartInfo.FileName = pdfkPath;
                        p.StartInfo.Arguments = cmd;
                        p.StartInfo.UseShellExecute = false;
                        p.Start();

                        p.WaitForExit();
                    }
                
            }
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            eVisible(false);
            button11.Visible = true;
            button12.Visible = true;
            button14.Visible = true;
            button16.Visible = true;
            button18.Visible = true;
            button20.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button13.Visible = true;
            button15.Visible = true;
            button17.Visible = true;
            button19.Visible = true;
            button21.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            MultiplePDF = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            eVisible(false);
            button10.Visible = true;
            button13.Visible = true;
            button15.Visible = true;
            button17.Visible = true;
            button19.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            checkBox1.Visible = true;
            MultiplePDF = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if(textBox8.Visible == true)
            {
                textBox8.Visible = false;
                textBox8.Clear();
            }
            else
            { textBox8.Visible = true; }
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
