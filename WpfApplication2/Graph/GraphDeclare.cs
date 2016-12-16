using Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.Graph
{
    class GraphDeclare
    {
        public Gp graph { get; set; }
        public GraphDeclare()
        {

            #region Graph Declaration
            graph = new Gp(15);
            graph.Size = 15;
            #region Elements Values
            graph.Elements[0].Value = 1;
            graph.Elements[1].Value = 2;
            graph.Elements[2].Value = 3;
            graph.Elements[3].Value = 4;
            graph.Elements[4].Value = 5;
            graph.Elements[5].Value = 6;
            graph.Elements[6].Value = 7;
            graph.Elements[7].Value = 8;
            graph.Elements[8].Value = 9;
            graph.Elements[9].Value = 10;
            graph.Elements[10].Value = 11;
            graph.Elements[11].Value = 12;
            graph.Elements[12].Value = 13;
            graph.Elements[13].Value = 14;
            graph.Elements[14].Value = 15;
            #endregion
            #region ELement 1 Declaration
            graph.Elements[0].Adjesent[0] = 0;
            graph.Elements[0].Adjesent[1] = 0;
            graph.Elements[0].Adjesent[2] = 1;
            graph.Elements[0].Adjesent[3] = 0;
            graph.Elements[0].Adjesent[4] = 0;
            graph.Elements[0].Adjesent[5] = 0;
            graph.Elements[0].Adjesent[6] = 0;
            graph.Elements[0].Adjesent[7] = 0;
            graph.Elements[0].Adjesent[8] = 0;
            graph.Elements[0].Adjesent[9] = 0;
            graph.Elements[0].Adjesent[10] = 0;
            graph.Elements[0].Adjesent[11] = 0;
            graph.Elements[0].Adjesent[12] = 0;
            graph.Elements[0].Adjesent[13] = 0;
            graph.Elements[0].Adjesent[14] = 0;
            #endregion
            #region ELement 2 Declaration
            graph.Elements[1].Adjesent[0] = 0;
            graph.Elements[1].Adjesent[1] = 0;
            graph.Elements[1].Adjesent[2] = 1;
            graph.Elements[1].Adjesent[3] = 0;
            graph.Elements[1].Adjesent[4] = 0;
            graph.Elements[1].Adjesent[5] = 0;
            graph.Elements[1].Adjesent[6] = 0;
            graph.Elements[1].Adjesent[7] = 0;
            graph.Elements[1].Adjesent[8] = 0;
            graph.Elements[1].Adjesent[9] = 0;
            graph.Elements[1].Adjesent[10] = 0;
            graph.Elements[1].Adjesent[11] = 0;
            graph.Elements[1].Adjesent[12] = 0;
            graph.Elements[1].Adjesent[13] = 0;
            graph.Elements[1].Adjesent[14] = 0;
            #endregion
            #region ELement 3 Declaration
            graph.Elements[2].Adjesent[0] = 1;
            graph.Elements[2].Adjesent[1] = 1;
            graph.Elements[2].Adjesent[2] = 0;
            graph.Elements[2].Adjesent[3] = 0;
            graph.Elements[2].Adjesent[4] = 0;
            graph.Elements[2].Adjesent[5] = 1;
            graph.Elements[2].Adjesent[6] = 0;
            graph.Elements[2].Adjesent[7] = 0;
            graph.Elements[2].Adjesent[8] = 0;
            graph.Elements[2].Adjesent[9] = 1;
            graph.Elements[2].Adjesent[10] = 0;
            graph.Elements[2].Adjesent[11] = 0;
            graph.Elements[2].Adjesent[12] = 0;
            graph.Elements[2].Adjesent[13] = 0;
            graph.Elements[2].Adjesent[14] = 0;
            #endregion
            #region ELement 4 Declaration
            graph.Elements[3].Adjesent[0] = 0;
            graph.Elements[3].Adjesent[1] = 0;
            graph.Elements[3].Adjesent[2] = 0;
            graph.Elements[3].Adjesent[3] = 0;
            graph.Elements[3].Adjesent[5] = 1;
            graph.Elements[3].Adjesent[4] = 0;
            graph.Elements[3].Adjesent[6] = 0;
            graph.Elements[3].Adjesent[7] = 0;
            graph.Elements[3].Adjesent[8] = 0;
            graph.Elements[3].Adjesent[9] = 0;
            graph.Elements[3].Adjesent[10] = 0;
            graph.Elements[3].Adjesent[11] = 0;
            graph.Elements[3].Adjesent[12] = 0;
            graph.Elements[3].Adjesent[13] = 0;
            graph.Elements[3].Adjesent[14] = 0;
            #endregion
            #region ELement 5 Declaration
            graph.Elements[4].Adjesent[0] = 0;
            graph.Elements[4].Adjesent[1] = 0;
            graph.Elements[4].Adjesent[2] = 0;
            graph.Elements[4].Adjesent[3] = 0;
            graph.Elements[4].Adjesent[4] = 0;
            graph.Elements[4].Adjesent[5] = 1;
            graph.Elements[4].Adjesent[6] = 0;
            graph.Elements[4].Adjesent[7] = 0;
            graph.Elements[4].Adjesent[8] = 0;
            graph.Elements[4].Adjesent[9] = 0;
            graph.Elements[4].Adjesent[10] = 0;
            graph.Elements[4].Adjesent[11] = 0;
            graph.Elements[4].Adjesent[12] = 0;
            graph.Elements[4].Adjesent[13] = 0;
            graph.Elements[4].Adjesent[14] = 0;
            #endregion
            #region Elemnt 6 Declaration
            graph.Elements[5].Adjesent[0] = 0;
            graph.Elements[5].Adjesent[1] = 0;
            graph.Elements[5].Adjesent[2] = 1;
            graph.Elements[5].Adjesent[3] = 1;
            graph.Elements[5].Adjesent[4] = 1;
            graph.Elements[5].Adjesent[5] = 0;
            graph.Elements[5].Adjesent[6] = 0;
            graph.Elements[5].Adjesent[7] = 0;
            graph.Elements[5].Adjesent[8] = 0;
            graph.Elements[5].Adjesent[9] = 1;
            graph.Elements[5].Adjesent[10] = 0;
            graph.Elements[5].Adjesent[11] = 0;
            graph.Elements[5].Adjesent[12] = 0;
            graph.Elements[5].Adjesent[13] = 0;
            graph.Elements[5].Adjesent[14] = 0;
            #endregion
            #region Element 7 Declaration
            graph.Elements[6].Adjesent[0] = 0;
            graph.Elements[6].Adjesent[1] = 0;
            graph.Elements[6].Adjesent[2] = 0;
            graph.Elements[6].Adjesent[3] = 0;
            graph.Elements[6].Adjesent[4] = 0;
            graph.Elements[6].Adjesent[5] = 0;
            graph.Elements[6].Adjesent[6] = 0;
            graph.Elements[6].Adjesent[7] = 0;
            graph.Elements[6].Adjesent[8] = 0;
            graph.Elements[6].Adjesent[9] = 1;
            graph.Elements[6].Adjesent[10] = 0;
            graph.Elements[6].Adjesent[11] = 0;
            graph.Elements[6].Adjesent[12] = 0;
            graph.Elements[6].Adjesent[13] = 0;
            graph.Elements[6].Adjesent[14] = 0;
            #endregion
            #region Element 8 Declaration
            graph.Elements[7].Adjesent[0] = 0;
            graph.Elements[7].Adjesent[1] = 0;
            graph.Elements[7].Adjesent[2] = 0;
            graph.Elements[7].Adjesent[3] = 0;
            graph.Elements[7].Adjesent[4] = 0;
            graph.Elements[7].Adjesent[5] = 0;
            graph.Elements[7].Adjesent[6] = 0;
            graph.Elements[7].Adjesent[7] = 0;
            graph.Elements[7].Adjesent[8] = 1;
            graph.Elements[7].Adjesent[9] = 0;
            graph.Elements[7].Adjesent[10] = 0;
            graph.Elements[7].Adjesent[11] = 0;
            graph.Elements[7].Adjesent[12] = 0;
            graph.Elements[7].Adjesent[13] = 0;
            graph.Elements[7].Adjesent[14] = 0;
            #endregion
            #region 9 Declaration
            graph.Elements[8].Adjesent[0] = 0;
            graph.Elements[8].Adjesent[1] = 0;
            graph.Elements[8].Adjesent[2] = 0;
            graph.Elements[8].Adjesent[3] = 0;
            graph.Elements[8].Adjesent[4] = 0;
            graph.Elements[8].Adjesent[5] = 0;
            graph.Elements[8].Adjesent[6] = 0;
            graph.Elements[8].Adjesent[7] = 1;
            graph.Elements[8].Adjesent[8] = 0;
            graph.Elements[8].Adjesent[9] = 1;
            graph.Elements[8].Adjesent[10] = 1;
            graph.Elements[8].Adjesent[11] = 0;
            graph.Elements[8].Adjesent[12] = 0;
            graph.Elements[8].Adjesent[13] = 0;
            graph.Elements[8].Adjesent[14] = 0;
            #endregion
            #region Element 10 Declaration
            graph.Elements[9].Adjesent[0] = 0;
            graph.Elements[9].Adjesent[1] = 0;
            graph.Elements[9].Adjesent[2] = 1;
            graph.Elements[9].Adjesent[3] = 0;
            graph.Elements[9].Adjesent[4] = 0;
            graph.Elements[9].Adjesent[5] = 1;
            graph.Elements[9].Adjesent[6] = 1;
            graph.Elements[9].Adjesent[7] = 0;
            graph.Elements[9].Adjesent[8] = 1;
            graph.Elements[9].Adjesent[9] = 0;
            graph.Elements[9].Adjesent[10] = 0;
            graph.Elements[9].Adjesent[11] = 0;
            graph.Elements[9].Adjesent[12] = 0;
            graph.Elements[9].Adjesent[13] = 0;
            graph.Elements[9].Adjesent[14] = 0;
            #endregion
            #region Element 11 Declaration
            graph.Elements[10].Adjesent[0] = 0;
            graph.Elements[10].Adjesent[1] = 0;
            graph.Elements[10].Adjesent[2] = 0;
            graph.Elements[10].Adjesent[3] = 0;
            graph.Elements[10].Adjesent[4] = 0;
            graph.Elements[10].Adjesent[5] = 0;
            graph.Elements[10].Adjesent[6] = 0;
            graph.Elements[10].Adjesent[7] = 0;
            graph.Elements[10].Adjesent[8] = 1;
            graph.Elements[10].Adjesent[9] = 0;
            graph.Elements[10].Adjesent[10] = 0;
            graph.Elements[10].Adjesent[11] = 1;
            graph.Elements[10].Adjesent[12] = 1;
            graph.Elements[10].Adjesent[13] = 1;
            graph.Elements[10].Adjesent[14] = 1;
            #endregion
            #region Element 12 Declaration
            graph.Elements[11].Adjesent[0] = 0;
            graph.Elements[11].Adjesent[1] = 0;
            graph.Elements[11].Adjesent[2] = 0;
            graph.Elements[11].Adjesent[3] = 0;
            graph.Elements[11].Adjesent[4] = 0;
            graph.Elements[11].Adjesent[5] = 0;
            graph.Elements[11].Adjesent[6] = 0;
            graph.Elements[11].Adjesent[7] = 0;
            graph.Elements[11].Adjesent[8] = 0;
            graph.Elements[11].Adjesent[9] = 0;
            graph.Elements[11].Adjesent[10] = 1;
            graph.Elements[11].Adjesent[11] = 0;
            graph.Elements[11].Adjesent[12] = 0;
            graph.Elements[11].Adjesent[13] = 0;
            graph.Elements[11].Adjesent[14] = 0;
            #endregion
            #region Element 13 Declaration
            graph.Elements[12].Adjesent[0] = 0;
            graph.Elements[12].Adjesent[1] = 0;
            graph.Elements[12].Adjesent[2] = 0;
            graph.Elements[12].Adjesent[3] = 0;
            graph.Elements[12].Adjesent[4] = 0;
            graph.Elements[12].Adjesent[5] = 0;
            graph.Elements[12].Adjesent[6] = 0;
            graph.Elements[12].Adjesent[7] = 0;
            graph.Elements[12].Adjesent[8] = 0;
            graph.Elements[12].Adjesent[9] = 0;
            graph.Elements[12].Adjesent[10] = 1;
            graph.Elements[12].Adjesent[11] = 0;
            graph.Elements[12].Adjesent[12] = 0;
            graph.Elements[12].Adjesent[13] = 0;
            graph.Elements[12].Adjesent[14] = 0;
            #endregion
            #region Element 14 Declaration
            graph.Elements[13].Adjesent[0] = 0;
            graph.Elements[13].Adjesent[1] = 0;
            graph.Elements[13].Adjesent[2] = 0;
            graph.Elements[13].Adjesent[3] = 0;
            graph.Elements[13].Adjesent[4] = 0;
            graph.Elements[13].Adjesent[5] = 0;
            graph.Elements[13].Adjesent[6] = 0;
            graph.Elements[13].Adjesent[7] = 0;
            graph.Elements[13].Adjesent[8] = 0;
            graph.Elements[13].Adjesent[9] = 0;
            graph.Elements[13].Adjesent[10] = 1;
            graph.Elements[13].Adjesent[11] = 0;
            graph.Elements[13].Adjesent[12] = 0;
            graph.Elements[13].Adjesent[13] = 0;
            graph.Elements[13].Adjesent[14] = 0;
            #endregion
            #region Element 15 Declaration
            graph.Elements[14].Adjesent[0] = 0;
            graph.Elements[14].Adjesent[1] = 0;
            graph.Elements[14].Adjesent[2] = 0;
            graph.Elements[14].Adjesent[3] = 0;
            graph.Elements[14].Adjesent[4] = 0;
            graph.Elements[14].Adjesent[5] = 0;
            graph.Elements[14].Adjesent[6] = 0;
            graph.Elements[14].Adjesent[7] = 0;
            graph.Elements[14].Adjesent[8] = 0;
            graph.Elements[14].Adjesent[9] = 0;
            graph.Elements[14].Adjesent[10] = 1;
            graph.Elements[14].Adjesent[11] = 0;
            graph.Elements[14].Adjesent[12] = 0;
            graph.Elements[14].Adjesent[13] = 0;
            graph.Elements[14].Adjesent[14] = 0;
            #endregion
            #endregion
            
        }
        public List<string> GetStoryBoard(List<int> pathList)
        {
            int[] path = pathList.ToArray();
            List<string> storyBoard = new List<string>();
            for (int i = 0; i < path.Count()-1; i++)
            {
                #region income and out going of PC 1 and PC2 from switch lab1
                if (path[i]== 1 && path[i+1]==3)
                {
                    storyBoard.Add("sl_Pc1_R");
                }
                else if (path[i] == 3 && path[i + 1] == 1)
                {
                    storyBoard.Add("sl_Pc1_F");
                }
                else if (path[i]==2 && path[i+1]==3)
                {
                    storyBoard.Add("sl_Pc2_R");
                }
                else if (path[i] == 3 && path[i + 1] == 2)
                {
                    storyBoard.Add("sl_Pc2_F");
                }
                #endregion
                #region income and out going of PC 4 and PC5 from switch lab1
                if (path[i] == 4 && path[i + 1] == 6)
                {
                    storyBoard.Add("sl2-pc1-R");
                }
                else if (path[i] == 6 && path[i + 1] == 4)
                {
                    storyBoard.Add("sl2-pc1-F");
                }
                else if (path[i] == 5 && path[i + 1] == 6)
                {
                    storyBoard.Add("sl2-pc2-R");
                }
                else if (path[i] == 6 && path[i + 1] == 5)
                {
                    storyBoard.Add("sl2-pc2-F");
                }
                #endregion
                #region income and out going of Swith Lab1 and Switch Lab2 from switch lab1
                if (path[i] == 3 && path[i + 1] == 6)
                {
                    storyBoard.Add("sl1-sl2-F");
                }
                else if (path[i] == 6 && path[i + 1] == 3)
                {
                    storyBoard.Add("sl1-sl2-R");
                }
                
                #endregion
                #region income and out going of Swith Lab1 and Switch Lab2 from Switch Server
                if (path[i] == 3 && path[i + 1] == 10)
                {
                    storyBoard.Add("ss_sl_R");
                }
                else if (path[i] == 10 && path[i + 1] == 3)
                {
                    storyBoard.Add("ss_sl_F");
                }
                if (path[i] == 6 && path[i + 1] == 10)
                {
                    storyBoard.Add("ss-sl2-R");
                }
                else if (path[i] == 10 && path[i + 1] == 6)
                {
                    storyBoard.Add("ss-sl2-F");
                }

                #endregion
                #region income and outgoing of webserver and switch server
                if (path[i] == 10 && path[i + 1] == 7)
                {
                    storyBoard.Add("ss_ser_F");
                }
                else if (path[i] == 7 && path[i + 1] == 10)
                {
                    storyBoard.Add("ss_Ser_R");
                }
                //10 -7 ss_ser_F
                //7 - 10 ss_ser_R
                #endregion
                #region income and outgoing of Router and switch server
                if (path[i] == 10 && path[i + 1] == 9)
                {
                    storyBoard.Add("rt_ss_R");
                }
                else if (path[i] == 9 && path[i + 1] == 10)
                {
                    storyBoard.Add("rt_ss_F");
                }
                #endregion
                #region income and outgoing of Router and Cloud
                if (path[i] == 8 && path[i + 1] == 9)
                {
                    storyBoard.Add("ct_rp_R");
                }
                else if (path[i] == 9 && path[i + 1] == 8)
                {
                    storyBoard.Add("rt_acp_R");
                }
                #endregion
                #region income and outgoing of Router and Acess Point
                if (path[i] == 9 && path[i + 1] == 11)
                {
                    storyBoard.Add("rp_acp_f");
                }
                else if (path[i] == 11 && path[i + 1] == 9)
                {
                    storyBoard.Add("Rec_acp-rt-f");
                }
                #endregion
                #region income and outgoing of Acess Point and PC1,PC2,PC3,PC4
                // PC1
                if (path[i] == 12 && path[i + 1] == 11)
                {
                    storyBoard.Add("pc1-acc");
                }
                else if (path[i] == 11 && path[i + 1] == 12)
                {
                    storyBoard.Add("acp-pc1_R");
                }
                //PC2
                if (path[i] == 11 && path[i + 1] == 13)
                {
                    storyBoard.Add("acp-pc2_R");
                }
                else if (path[i] == 13 && path[i + 1] == 11)
                {
                    storyBoard.Add("pc2-acp_F");
                }
                //PC3
                if (path[i] == 11 && path[i + 1] == 14)
                {
                    storyBoard.Add("acp-pc3_R");
                }
                else if (path[i] == 14 && path[i + 1] == 11)
                {
                    storyBoard.Add("pc3-acp_F");
                }
                //PC4
                if (path[i] == 11 && path[i + 1] == 15)
                {
                    storyBoard.Add("acp-pc4_R");
                }
                else if (path[i] == 15 && path[i + 1] == 11)
                {
                    storyBoard.Add("pc4-acp_F");
                }
                #endregion
            }

            return storyBoard;
        }
    }
}
