using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uFR;
namespace RS232_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkReset_Click(object sender, EventArgs e)
        {
            if (checkReset.Checked == true)
            {
                checkReset.Text = "Reset enabled";
            } else if (checkReset.Checked == false)
            {
                checkReset.Text = "Reset disabled";
            }
        }

        private void btnReaderOpen_Click(object sender, EventArgs e)
        {
            DL_STATUS status;

            UInt32 reader_type_ex = 2;
            UInt32 port_interface = 1;
            string arg = "";
            string port_name = "";

            port_name = txtCOMPort.Text.ToUpper();

            if (port_name == "")
            {
                MessageBox.Show("Valid COM Port name is required!");
                txtCOMPort.Focus();
                return;
            }

            if (port_name.StartsWith("COM") == false)
            {
                port_name = "COM" + port_name;
            }

            if (checkReset.Checked == true )
            {
                arg = "";
            }
            else
            {
                arg = "UNIT_OPEN_RESET_DISABLE";
            }

            status = uFCoder.ReaderOpenEx(reader_type_ex, port_name, port_interface, arg);
            
            if (status != DL_STATUS.UFR_OK)
            {
                txtReaderStatus.Text = "NOT CONNECTED";
                txtFunctionStatus.Text = uFCoder.status2str(status);

            }
            else
            {
                txtReaderStatus.Text = " CONNECTED";
                txtFunctionStatus.Text = uFCoder.status2str(status);

                UInt32 reader_type = 0;
                UInt32 reader_sn = 0;
                byte fw_major = 0, fw_minor = 0, hw_major = 0, hw_minor = 0, build = 0;

                status = uFCoder.GetReaderType(out reader_type);
                status = uFCoder.GetReaderSerialNumber(out reader_sn);
                status = uFCoder.GetReaderFirmwareVersion(out fw_major, out fw_minor);
                status = uFCoder.GetReaderHardwareVersion(out hw_major, out hw_minor);
                status = uFCoder.GetBuildNumber(out build);

                if (status != 0)
                {
                    txtReaderStatus.Text = "NOT CONNECTED";
                    txtFunctionStatus.Text = uFCoder.status2str(status);
                }
                else
                {
                    txtReaderSN.Text = reader_sn.ToString();
                    txtReaderType.Text = reader_type.ToString("X2");
                    txtFirmware.Text = fw_major.ToString() + "." + fw_minor.ToString() + "." + build.ToString();
                    txtHardware.Text = hw_major.ToString() + "." + hw_minor.ToString();

                    uFCoder.ReaderUISignal(1, 1);
                }
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dll = uFCoder.dll_version();
            txtDLL.Text = dll; 
        }

        private void btnGetCardInfo_click(object sender, EventArgs e)
        {
            DL_STATUS status;

            byte card_type = 0, uid_size = 0;
            byte[] uid= new byte[10];

            status = uFCoder.GetCardIdEx(out card_type, uid, out uid_size); 
            status = uFCoder.GetDlogicCardType(out card_type);
            if (status != 0)
            {
                txtFunctionStatus.Text = uFCoder.status2str(status);
                txtCardSerial.Clear();
                txtCardType.Clear();
                txtCardUIDSize.Clear();
                return;
            }
            byte[] shorter_uid = new byte[uid_size];
            Array.Copy(uid, shorter_uid, uid_size);

            txtCardType.Text = "0x" + card_type.ToString("X2");
            txtCardSerial.Text = BitConverter.ToString(shorter_uid).Replace('-',':');
            txtCardUIDSize.Text = uid_size.ToString();
        }
    }
}