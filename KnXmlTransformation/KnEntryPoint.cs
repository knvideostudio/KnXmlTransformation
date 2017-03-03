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
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace KnXmlTransformation
{
    public partial class KnEntryPoint : Form
    {

        public const string XML_PET_FILE = @"\Data\PetIDCard.xml";
        public const string XSL_PET_FILE = @"\Data\PetIDCard.xslt";
        public const string XML_RESULT_FILE = @"\Data\TransformedData.xml";

        public string GetExecutionPath
        {
            get
            {
                string sFullPath = Application.ExecutablePath;
                string sPath = System.IO.Path.GetDirectoryName(sFullPath);
                return (sPath);
            }
        }

        private string CheckIsAttributeExists(XmlNode myNode, string AtributeName)
        {
            string sTemp = string.Empty;
            string sNodeName = string.Empty;

            try
            {
                sNodeName = myNode.Name;
                sTemp = myNode.Attributes[AtributeName].Value;

            }
            catch (Exception exc)
            {

            }

            return (sTemp);
        }

        public KnEntryPoint()
        {
            InitializeComponent();
        }

        private void btnAnother_Click(object sender, EventArgs e)
        {
            int iPracticeCount = 0;
            int iClientCount = 0;
            int iPetCount = 0;
            int iReminderCount = 0;

            string[] PracticeArr = new string[18];
            string[] ClientArr = new string[11];
            string[] PetArr = new string[16];
            string[] ReminderArr = new string[10];

            string sPath = GetExecutionPath + XML_RESULT_FILE;
            XmlDocument doc = new XmlDocument();

            XmlNodeList nodePracticeList = null;
            XmlNodeList nodeClientList = null;
            XmlNodeList nodePetList = null;
            XmlNodeList nodeRemindeList = null;

            doc.Load(sPath);

            nodePracticeList = doc.SelectNodes("/Root/PracticeInfo");

            foreach (XmlNode ndPractice in nodePracticeList)
            {
                iPracticeCount++;

                PracticeArr[0] = CheckIsAttributeExists(ndPractice, "id");
                PracticeArr[1] = CheckIsAttributeExists(ndPractice, "name");
                PracticeArr[2] = CheckIsAttributeExists(ndPractice, "address1");
                PracticeArr[3] = CheckIsAttributeExists(ndPractice, "address2");
                PracticeArr[4] = CheckIsAttributeExists(ndPractice, "city");
                PracticeArr[5] = CheckIsAttributeExists(ndPractice, "state");
                PracticeArr[6] = CheckIsAttributeExists(ndPractice, "zip");

                PracticeArr[7] = CheckIsAttributeExists(ndPractice, "phone");
                PracticeArr[8] = CheckIsAttributeExists(ndPractice, "url");
                PracticeArr[9] = CheckIsAttributeExists(ndPractice, "email");
                PracticeArr[10] = CheckIsAttributeExists(ndPractice, "country");
                PracticeArr[11] = CheckIsAttributeExists(ndPractice, "logo");

                PracticeArr[12] = CheckIsAttributeExists(ndPractice, "emtname");
                PracticeArr[13] = CheckIsAttributeExists(ndPractice, "emtaddress");
                PracticeArr[14] = CheckIsAttributeExists(ndPractice, "emtcity");
                PracticeArr[15] = CheckIsAttributeExists(ndPractice, "emtstate");
                PracticeArr[16] = CheckIsAttributeExists(ndPractice, "emtzip");
                PracticeArr[17] = CheckIsAttributeExists(ndPractice, "emtphone");


                nodeClientList = ndPractice.SelectNodes("ClientInfo");
                foreach (XmlNode ndClient in nodeClientList)
                {
                    iClientCount++;

                    ClientArr[0] = CheckIsAttributeExists(ndClient, "id");
                    ClientArr[1] = CheckIsAttributeExists(ndClient, "firstname");
                    ClientArr[2] = CheckIsAttributeExists(ndClient, "lastname");
                    ClientArr[3] = CheckIsAttributeExists(ndClient, "title");
                    ClientArr[4] = CheckIsAttributeExists(ndClient, "address1");
                    ClientArr[5] = CheckIsAttributeExists(ndClient, "address2");

                    ClientArr[6] = CheckIsAttributeExists(ndClient, "city");
                    ClientArr[7] = CheckIsAttributeExists(ndClient, "state");
                    ClientArr[8] = CheckIsAttributeExists(ndClient, "zip");
                    ClientArr[9] = CheckIsAttributeExists(ndClient, "country");
                    ClientArr[10] = CheckIsAttributeExists(ndClient, "status");

                    nodePetList = ndClient.SelectNodes("Pet");
                    foreach (XmlNode ndPet in nodePetList)
                    {
                        iPetCount++;

                        PetArr[0] = CheckIsAttributeExists(ndPet, "id");
                        PetArr[1] = CheckIsAttributeExists(ndPet, "name");
                        PetArr[2] = CheckIsAttributeExists(ndPet, "species");
                        PetArr[3] = CheckIsAttributeExists(ndPet, "breed");
                        PetArr[4] = CheckIsAttributeExists(ndPet, "color");
                        PetArr[5] = CheckIsAttributeExists(ndPet, "weight");

                        PetArr[6] = CheckIsAttributeExists(ndPet, "weight");
                        PetArr[7] = CheckIsAttributeExists(ndPet, "sex");
                        PetArr[8] = CheckIsAttributeExists(ndPet, "rabiestag");
                        PetArr[9] = CheckIsAttributeExists(ndPet, "microchipid");
                        PetArr[10] = CheckIsAttributeExists(ndPet, "birthdate");

                        PetArr[11] = CheckIsAttributeExists(ndPet, "invno");
                        PetArr[12] = CheckIsAttributeExists(ndPet, "quantity");
                        PetArr[13] = CheckIsAttributeExists(ndPet, "preview");
                        PetArr[14] = CheckIsAttributeExists(ndPet, "photo");
                        PetArr[15] = CheckIsAttributeExists(ndPet, "allergy");

                        nodeRemindeList = ndPet.SelectNodes("Reminder");
                        foreach (XmlNode ndReminder in nodeRemindeList)
                        {
                            iReminderCount++;

                            ReminderArr[0] = CheckIsAttributeExists(ndReminder, "prid");
                            ReminderArr[1] = CheckIsAttributeExists(ndReminder, "clientid");
                            ReminderArr[2] = CheckIsAttributeExists(ndReminder, "patientid");
                            ReminderArr[3] = CheckIsAttributeExists(ndReminder, "invoice");
                            ReminderArr[4] = CheckIsAttributeExists(ndReminder, "id");

                            ReminderArr[5] = CheckIsAttributeExists(ndReminder, "name");
                            ReminderArr[6] = CheckIsAttributeExists(ndReminder, "cname");
                            ReminderArr[7] = CheckIsAttributeExists(ndReminder, "gdate");
                            ReminderArr[8] = CheckIsAttributeExists(ndReminder, "ddate");
                            ReminderArr[9] = CheckIsAttributeExists(ndReminder, "priority");
                        } // Reminder LOOP
                    } // Pet LOOP
                } // Client LOOP
            } // Pracrtice LOOP

            doc = null;
            string sTempo = "";

            int itPracticeCount = iPracticeCount;
            int itClientCount = iClientCount;
            int itPetCount = iPetCount;
            int itReminderCount = iReminderCount;

            sTempo = "";
        }

        private void btnLoopXml_Click(object sender, EventArgs e)
        {
            string sPath = GetExecutionPath + XML_RESULT_FILE;

            XPathNavigator nav;
            XPathDocument docNav;
            docNav = new XPathDocument(sPath);
            nav = docNav.CreateNavigator();

            nav.MoveToRoot();
            nav.MoveToFirstChild();

            do
            {
                //Find the first element.
                if (nav.NodeType == XPathNodeType.Element)
                {
                    //Determine whether children exist.
                    if (nav.HasChildren == true)
                    {

                        //Move to the first child.
                        nav.MoveToFirstChild();

                        //Loop through all of the children.
                        do
                        {
                            //Display the data.
                            Console.Write("The XML string for this child ");
                            Console.WriteLine("is '{0}'", nav.Value);

                            //Check for attributes.
                            if (nav.HasAttributes == true)
                            {
                                Console.WriteLine("This node has attributes");
                            }
                        } while (nav.MoveToNext());
                    }
                }
            } while (nav.MoveToNext());

        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            string sOutPut = string.Empty;

            string resultDoc = GetExecutionPath + @"\Data\result.xml";
            string sourceDoc = GetExecutionPath + XML_PET_FILE;
            string xsltDoc = GetExecutionPath + XSL_PET_FILE;

            XPathDocument myXPathDocument = new XPathDocument(sourceDoc);

            // XslTransform myXslTransform = new XslTransform();
            XslCompiledTransform myXslTransform = new XslCompiledTransform();
            XmlTextWriter writer = new XmlTextWriter(resultDoc, null);

            myXslTransform.Load(xsltDoc);
            myXslTransform.Transform(myXPathDocument, null, writer);
            writer.Close();

            StreamReader stream = new StreamReader(resultDoc);
            //Console.Write("**This is result document**\n\n");
            sOutPut = stream.ReadToEnd();

            Int32 iLen = sOutPut.LastIndexOf(">");
            string sFinalData = "<Root>" +
                sOutPut.Substring(0, iLen + 1) +
                "</Root>";


            txtXmlOutput.Text = sFinalData;
        }
    }
}
