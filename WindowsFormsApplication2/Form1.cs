using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dialogGetDataDir.ShowDialog() == DialogResult.OK)
            {
                textboxGetDataDir.Text = dialogGetDataDir.SelectedPath;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public bool CheckIfArrayIsNull(string strDataDir, out bool[] outputBoolArray)
        {

            bool[] boolarrayBethesdaMasters;
            CheckForBethesdaMasters(strDataDir, out boolarrayBethesdaMasters);

            int iNumberOfBooleans = boolarrayBethesdaMasters.Length;

            bool boolValidMaster = false; // Default value. Don't want to set it to true just yet.

            for (int iCounter = 0; iCounter < iNumberOfBooleans; iCounter++)
            {
                if (boolarrayBethesdaMasters[iCounter]
                    && boolValidMaster == false)
                {
                    boolValidMaster = true;
                }
            }

            outputBoolArray = boolarrayBethesdaMasters;
            return boolValidMaster;

        }

        public void CheckForBethesdaMasters(string strDataDir, out bool[] outputBoolArray)
        {
            outputBoolArray = new bool[7];

            if (File.Exists(strDataDir + "\\Fallout4.esm"))
            {
                outputBoolArray[0] = true;
            }

            else
            {
                outputBoolArray[0] = false;
            }


            if (File.Exists(strDataDir + "\\DLCRobot.esm"))
            {
                outputBoolArray[1] = true;
            }

            else
            {
                outputBoolArray[1] = false;
            }


            if (File.Exists(strDataDir + "\\DLCworkshop01.esm"))
            {
                outputBoolArray[2] = true;
            }

            else
            {
                outputBoolArray[2] = false;
            }


            if (File.Exists(strDataDir + "\\DLCCoast.esm"))
            {
                outputBoolArray[3] = true;
            }

            else
            {
                outputBoolArray[3] = false;
            }


            if (File.Exists(strDataDir + "\\DLCworkshop02.esm"))
            {
                outputBoolArray[4] = true;
            }

            else
            {
                outputBoolArray[4] = false;
            }


            if (File.Exists(strDataDir + "\\DLCworkshop03.esm"))
            {
                outputBoolArray[5] = true;
            }

            else
            {
                outputBoolArray[5] = false;
            }


            if (File.Exists(strDataDir + "\\DLCNukaWorld.esm"))
            {
                outputBoolArray[6] = true;
            }

            else
            {
                outputBoolArray[6] = false;
            }

        }

        public void RedateMasters(string strDataDir, bool[] boolarrayBethesdaMasters)
        {
            
            //Using the official release dates 'ere. Aren't I just fabulous?

            DateTime datetimecreatedFallout4 = new DateTime(2015, 09, 10);

            DateTime datetimecreatedAutomatron = new DateTime(2016, 03, 22);
            DateTime datetimecreatedWastelandWorkshop = new DateTime(2016, 04, 12);
            DateTime datetimecreatedFarHarbor = new DateTime(2016, 05, 19);
            DateTime datetimecreatedContraptionsWorkshop = new DateTime(2016, 06, 21);
            DateTime datetimecreatedVaultTecWorkshop = new DateTime(2016, 07, 26);

            DateTime datetimecreatedNukaWorld = new DateTime(2016, 08, 30);

            if (boolarrayBethesdaMasters[0])
            {
                string strFullPathToMaster = strDataDir + "\\Fallout4.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedFallout4);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedFallout4);
            }

            if (boolarrayBethesdaMasters[1])
            {
                string strFullPathToMaster = strDataDir + "\\DLCRobot.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedAutomatron);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedAutomatron);
            }

            if (boolarrayBethesdaMasters[2])
            {
                string strFullPathToMaster = strDataDir + "\\DLCworkshop01.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedWastelandWorkshop);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedWastelandWorkshop);
            }

            if (boolarrayBethesdaMasters[3])
            {
                string strFullPathToMaster = strDataDir + "\\DLCCoast.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedFarHarbor);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedFarHarbor);
            }

            if (boolarrayBethesdaMasters[4])
            {
                string strFullPathToMaster = strDataDir + "\\DLCworkshop02.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedContraptionsWorkshop);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedContraptionsWorkshop);
            }

            if (boolarrayBethesdaMasters[5])
            {
                string strFullPathToMaster = strDataDir + "\\DLCworkshop03.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedVaultTecWorkshop);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedVaultTecWorkshop);
            }

            if (boolarrayBethesdaMasters[6])
            {
                string strFullPathToMaster = strDataDir + "\\DLCNukaWorld.esm";
                File.SetCreationTime(strFullPathToMaster, datetimecreatedNukaWorld);
                File.SetLastWriteTime(strFullPathToMaster, datetimecreatedNukaWorld);
            }
        }

        private void buttonRedate_Click(object sender, EventArgs e)
        {
            string strDataDir = textboxGetDataDir.Text;
            MessageBox.Show(strDataDir);

            bool[] boolarrayBethesdaMasterExistence;

            if (strDataDir.Length > 0
                && CheckIfArrayIsNull(strDataDir, out boolarrayBethesdaMasterExistence)
                )
            {
                RedateMasters(strDataDir, boolarrayBethesdaMasterExistence);
                MessageBox.Show("Aaaaaand we're done!");
            }

            else
            {
                MessageBox.Show("Nae masters found, lad. Make sure you got the proper folder, containing (any of) the official Bethesda .esm files.");
            }
             
        }

    }
}
