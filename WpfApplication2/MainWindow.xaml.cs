using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Graph;
using WpfApplication2.Graph;
using System.Timers;
using System.Threading;
using System.Diagnostics;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
       private static List<Storyboard> storyBordList = new List<Storyboard>();
       private int j = 0;
       private int k = 0;
       private int seq = 0;
    
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void setDestheaders()
        {
            lblSequenceNumber1.Content = "00000000";
            lblHeaderLength1.Content = "101000";
            lblACKNumber1.Content = "00000001";
            lblResearved1.Content = "111";
            lblPreEmble_Copy.Content = "10101010-11";
            lblFlag1.Content = "1000";
            lblWindow1.Content = "32K";
            IP_lbl_IHL1.Content = "011";
            lblCheckSum1.Content = "0000";
            IP_lbl_DS1.Content = "10101011";
            IP_lbl_TotalLength1.Content = "00000000";
            IP_lbl_Flag1.Content = "000";
            EthernetDestAddr_Rcvr.Content = lblEthernetSrcAddress.Content;
            EthernetSRCAddr_RCVR.Content = lblEthernetDestAddr.Content;
            IP_lbl_TimeToLive1.Content = "111";
            IP_lbl_Protocol1.Content = "TCP";
            EthernetType_Rcvr.Content = "11";
            EthernetCRC_Rcvr.Content = "0101";
            IP_lbl_HeaderChecksum1.Content = "111000011101011";
            IP_lbl_Identification1.Content = "0111";
            lblOptionsPading1.Content = "00000000";
            IP_lbl_OptionsPadding1.Content = "110100101010010100101000110000";

        }

        private void setHeaders()
        {
            IP_lbl_OptionsPadding.Content = "111001111100000011111110101010111";
            lblHeaderLength.Content = "101000";
            IP_lbl_TimeToLive.Content = "111";
            IP_lbl_Protocol.Content = "TCP";
            IP_lbl_HeaderChecksum.Content = "10101010100000000";
            lblUrgentPointer.Content = "0000000000000000";
            lblSequenceNumber.Content = "00000001";
            lblEthernetType.Content = "10";
            LblEthernetCrC.Content = "1010";

            
           
            lblACKNumber.Content = "0000000";
           
            lblResearved.Content = "111";
            
                lblPreEmble.Content="10101010-11";
              
          
           lblFlag.Content = "1000";
           
           lblWindow.Content = "32kb";
           

           String richt = new TextRange(rtbData.Document.ContentStart, rtbData.Document.ContentEnd).Text;
           int b = int.Parse(richt.Length.ToString());
          int c= int.Parse(txtSubject.Text.Length.ToString())+b;
           
          lblCheckSum.Content = b.ToString();
           
           
           lblOptionsPading.Content = c.ToString() + "," + "32"+",";
          
           IP_lbl_DS.Content = "10111000";
          

           IP_lbl_IHL.Content = "1111";
           
           IP_lbl_ECN.Content = "00";
           IP_lbl_TotalLength.Content = "1111+" + c.ToString();
          
           IP_lbl_Identification.Content = "1111";
           
           IP_lbl_Flag.Content = "000";
          

        }
        #region Get Source And Destination Address
        private int[] getSrcnDxtAdd(String srcIP,String destIp)
        {
            int[] ad = new int[2];
            switch (srcIP)      // SOurce
            {
                case "65.55.2.47":
                    {
                        lblSourcePort.Content = "80";
                        IP_lbl_SourceAddress.Content = "65.55.2.47";
                        lblEthernetSrcAddress.Content = "2C:a1:c7:0:2d::d4";
                        
                     setHeaders();
                       

                        ad[0] = 6;

                        break;
                     }
                case "192.168.1.1":
                    {
                        lblSourcePort.Content = "1211";
                        IP_lbl_SourceAddress.Content = "192.168.1.1";
                        lblEthernetSrcAddress.Content = "1e:2f:0:1b:6c:0b";
                       setHeaders();
                        ad[0] = 0;
                        break;
                    }
                case "192.168.1.2":
                    {
                        lblSourcePort.Content = "3214";
                        IP_lbl_SourceAddress.Content = "192.168.1.2";
                        lblEthernetSrcAddress.Content = "00:2f:1b:a1:c7:0";
                        setHeaders();
                        ad[0] = 1;
                        break;
                    }
                case "192.168.2.1":
                    {
                        lblSourcePort.Content = "1221";
                        IP_lbl_SourceAddress.Content = "192.168.2.1";
                        setHeaders();
                        lblEthernetSrcAddress.Content = "00:2c:1:a1:c7:0e";
                        ad[0] = 3;
                        break;
                    }
                case "192.168.0.1":
                    {
                        lblSourcePort.Content = "445";
                       IP_lbl_SourceAddress.Content = "192.168.0.1";
                       setHeaders();
                       lblEthernetSrcAddress.Content = "00:1c:2b:4c:88:3B";
                        ad[0] = 11;
                        break;
                    }
                case "192.168.0.2":
                    {
                        lblSourcePort.Content = "333";
                        IP_lbl_SourceAddress.Content = "192.168.0.2";
                        setHeaders();
                        lblEthernetSrcAddress.Content = "11:00:c6:4B:2c:22";
                        ad[0] = 12;
                        break;
                    }
                case "192.168.0.3":
                    {
                        lblSourcePort.Content = "909";
                        IP_lbl_SourceAddress.Content = "192.168.0.3";
                        setHeaders();
                        lblEthernetSrcAddress.Content = "10:21:2b:4c:77:88";
                        ad[0] = 13;
                        break;
                    }
                case "192.168.0.4":
                    {
                        lblSourcePort.Content = "767";
                        IP_lbl_SourceAddress.Content = "192.168.0.4";
                        setHeaders();
                        lblEthernetSrcAddress.Content = "2c:4a:7:0:2A:9b";
                        ad[0] = 14;
                        break;
                    }
                case "192.168.2.2":
                    {
                        lblSourcePort.Content = "2233";
                        IP_lbl_SourceAddress.Content = "192.168.2.2";
                        setHeaders();
                        lblEthernetSrcAddress.Content = "00:1f:1C:a1:C7:0";
                        ad[0] = 4;
                        break;
                    }
                case "32.32.33.1":
                    {
                        lblSourcePort.Content = "80";
                        IP_lbl_SourceAddress.Content = "32.32.33.1";
                        lblEthernetSrcAddress.Content = "1C:3b:00:00:77:3C";
                        ad[0] = 7;
                        setHeaders();
                        break;
                    }
               
            }
            /////////////////////////////////////////////Destination///////////////////////////////
                    switch (destIp)
            {
                case "65.55.2.47":
                    {
                        lblSourcePort.Content = "80";
                        IP_lbl_DestinationAddress.Content = "65.55.2.47";
                        
                        lblEthernetDestAddr.Content = "2C:a1:c7:0:2d::d4";
                      
                        ad[0] = 6;
                        break;

                    }
                case "192.168.1.1":
                    {
                        lblDestinationPort.Content = "1211";
                        IP_lbl_DestinationAddress.Content = "192.168.1.1";
                        
                        lblEthernetDestAddr.Content = "1e:2f:0:1b:6c:0b";
                        ad[1] = 0;
                        break;
                    }
                case "192.168.1.2":
                    {
                        lblDestinationPort.Content = "3214";
                        IP_lbl_DestinationAddress.Content = "192.168.1.2";
                        
                        lblEthernetDestAddr.Content = "00:2f:1b:a1:c7:0";
                        ad[1] = 1;
                        break;
                    }
                case "192.168.2.1":
                    {
                        lblDestinationPort.Content = "1221";
                        IP_lbl_DestinationAddress.Content = "192.168.2.1";
                        
                        lblEthernetDestAddr.Content = "00:2c:1:a1:c7:0e";
                        ad[1] = 3;
                        break;
                    }
                case "192.168.0.1":
                    {
                        lblDestinationPort.Content = "445";
                        IP_lbl_DestinationAddress.Content = "192.168.0.1";
                  
                        lblEthernetDestAddr.Content = "00:1c:2b:4c:88:3B";
                        ad[1] = 11;
                        break;
                    }
                case "192.168.0.2":
                    {
                        lblDestinationPort.Content = "333";
                        IP_lbl_DestinationAddress.Content = "192.168.0.2";
                   
                        lblEthernetDestAddr.Content = "11:00:c6:4B:2c:22";
                        ad[1] = 12;
                        break;
                    }
                case "192.168.0.3":
                    {
                        lblDestinationPort.Content = "909";
                        IP_lbl_DestinationAddress.Content = "192.168.0.3";
                        ad[1] = 13;
                        lblEthernetSrcAddress.Content = "10:21:2b:4c:77:88";
                      
                        break;
                    }
                case "192.168.0.4":
                    {
                        lblDestinationPort.Content = "767";
                        IP_lbl_DestinationAddress.Content = "192.168.0.4";
                
                        lblEthernetDestAddr.Content = "2c:4a:7:0:2A:9b";
                        ad[1] = 14;
                        break;
                    }
                case "192.168.2.2":
                    {
                        lblDestinationPort.Content = "2233";
                        IP_lbl_DestinationAddress.Content = "192.168.2.2";

                        lblEthernetDestAddr.Content = "00:1f:1C:a1:C7:0";
                        ad[1] = 4;
                        
                        break;
                    }
                case "32.32.33.1":
                    {
                        lblDestinationPort.Content = "80";
                        IP_lbl_DestinationAddress.Content = "32.32.33.1";
                        lblEthernetSrcAddress.Content = "1C:3b:00:00:77:3C";
                       
                        ad[1] = 7;
                        break;
                    }
               
            }
           

            return ad;

        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] addr = getSrcnDxtAdd(txtSender.Text,txtReciever.Text);
            getAnimation(addr[0],addr[1],0);
        }
        public void getAnimation(int srcAddr, int DestAddr,int jl)
        {

            
            storyBordList.Clear();

            GraphDeclare gd = new GraphDeclare();
            List<int> PathIntegers = gd.graph.Tracking(gd.graph, gd.graph.Elements[srcAddr], gd.graph.Elements[DestAddr]);
            List<string> StoryLists = gd.GetStoryBoard(PathIntegers);

            foreach (var item in StoryLists)
            {
                var beginsb = (Storyboard)FindResource(item.ToString());
                storyBordList.Add(beginsb);

            }
            if(jl==0)
            StartStoryBoard();
            if (jl == 1)
                RevrsStoryBoard();
        }
        public void StartStoryBoard()
        {
            storyBordList[0].Begin();

            k = 0;
           

        }
        public void RevrsStoryBoard()
        {
            storyBordList[0].Begin();
            k = 1;
            setDestheaders();

        }

       
       private void MainWindow_Completed(object sender, EventArgs e)
        {
            j++;
            storyBordList[j].Begin();

        }
       private void timeLine_Completed(object sender, EventArgs e)
       {

          storyBordList.Clear();
          
          j = 0;
           if(k==0)
           {
          int[] addr = getSrcnDxtAdd(txtReciever.Text, txtSender.Text);
          getAnimation(addr[0], addr[1],1);
           }

          Storyboard s = (Storyboard)TryFindResource("Ending");
          s.Begin();
          lblDestinationPort1.Content = lblDestinationPort.Content;
          lblSourcePort1.Content = lblSourcePort.Content;
          IP_lbl_DestinationAddress1.Content = IP_lbl_DestinationAddress.Content;
          IP_lbl_SourceAddress1.Content = IP_lbl_SourceAddress.Content;
          lblSubReciever.Content = txtSubject.Text;
          String richtext = new TextRange(rtbData.Document.ContentStart, rtbData.Document.ContentEnd).Text;
          txtDataReceiver.Text = richtext;
           


       }

        private void Label_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this.Close();
            
        }


        private void Label_MouseDoubleClick_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	this.WindowState=System.Windows.WindowState.Minimized;
			
		}

            private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close();
			// TODO: Add event handler implementation here.
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.WindowState=System.Windows.WindowState.Minimized;
			// TODO: Add event handler implementation here.
        }

        private void txtSubject_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	txtSubject.SelectAll();// TODO: Add event handler implementation here.
        }

        private void rtbData_GotMouseCapture(object sender, System.Windows.Input.MouseEventArgs e)
        {
        	rtbData.SelectAll();// TODO: Add event handler implementation here.
        }

    }
    
}

