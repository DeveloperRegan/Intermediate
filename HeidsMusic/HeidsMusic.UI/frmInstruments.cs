using System;
using System.Windows.Forms;
using HeidsMusic.Business;
using HeidsMusic.Utility;

namespace HeidsMusic.Presentation
{
    public partial class frmInstruments : Form
    {
        private BrassCollection oBrassCollection;
        private WoodwindCollection oWoodwindCollection;

        public frmInstruments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oBrassCollection = new BrassCollection();
            oWoodwindCollection = new WoodwindCollection();
        }


        private void btnFillBrass_Click(object sender, EventArgs e)
        {
            // Constructor params: Finish, Valve Count (INT), Cost (FLOAT), Manufacturer, Model, InstrumentType)

            Brass oBrass = new Brass("Brass", 3, 345.0f, "Getzen", "Seversen", InstrumentType.Trumpet);
            oBrassCollection.Add(oBrass);

            oBrass = new Brass("Silver", 2, 450.0f, "Bundy", "G6", InstrumentType.Tuba);
            oBrassCollection.Add(oBrass);

            dgvBrass.AutoGenerateColumns = true;
            dgvBrass.DataSource = oBrassCollection.BrassList;
        }

        private void btnFillWoodwinds_Click(object sender, EventArgs e)
        {
            // Constructor params: ReedType, Reed Size (INT), Cost (FLOAT), Manufacturer, Model, InstrumentType)

            Woodwind oWoodwind = new Woodwind("Single", 1, 340.0f, "Clarinets and Stuff", "Glenwour", InstrumentType.Bassoon);
            oWoodwindCollection.Add(oWoodwind);

            oWoodwind = new Woodwind("Double", 2, 490.0f, "We be Reeds", "G6", InstrumentType.Clarinet);
            oWoodwindCollection.Add(oWoodwind);

            dgvWoodwinds.AutoGenerateColumns = true;
            dgvWoodwinds.DataSource = oWoodwindCollection.WoodwindList;
        }

        private void btnSaveBrass_Click(object sender, EventArgs e)
        {
            try
            {
                oBrassCollection.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadBrass_Click(object sender, EventArgs e)
        {
            try
            {
                oBrassCollection.Load();
                dgvBrass.AutoGenerateColumns = true;
                dgvBrass.DataSource = oBrassCollection.BrassList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oWoodwindCollection.Load();
                dgvWoodwinds.AutoGenerateColumns = true;
                dgvWoodwinds.DataSource = oWoodwindCollection.WoodwindList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oWoodwindCollection.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearBrass_Click(object sender, EventArgs e)
        {
            dgvBrass.DataSource = null;
            oBrassCollection = new BrassCollection();

        }

        private void btnClearWoodwinds_Click(object sender, EventArgs e)
        {
            dgvWoodwinds.DataSource = null;
            oWoodwindCollection = new WoodwindCollection();
        }
    }
}
