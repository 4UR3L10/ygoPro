using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Hand> HandList = new List<Hand>();
        int test = 300;

        public class Hand
        {
            private string name;
            private string attribute;
            private int level;
            private string typeOfCard;
            private string type;
            private string effect;
            private int atk;
            private int def;
            private string id;

            public Hand(string name, string attribute, int level, string typeOfCard, string type, string effect, int atk, int def, string id)
            {
                this.name = name;
                this.attribute = attribute;
                this.level = level;
                this.typeOfCard = typeOfCard;
                this.type = type;
                this.effect = effect;
                this.atk = atk;
                this.def = def;
                this.id = id;
            }

            public string getId()
            {
                return id;
            }


        }

        public Form1()
        {
            InitializeComponent();
            
            HandList.Add(new Hand("Dark Magician", "Dark", 7, "Monster", "Normal", "None", 2500, 2100, "46986414"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            Label dynamicLabel = new Label();
            dynamicLabel.Location = new Point(test, 700);
            dynamicLabel.Height = 122;            
            dynamicLabel.Width = 122;           
            dynamicLabel.Image = Image.FromFile(@"C:\Users\aurel\Documents\Visual Studio Projects\ygo\WindowsFormsApp2\WindowsFormsApp2\pics\cards\cards (81x122)\" + HandList[0].getId() + ".jpg");
            test = test + 100;
            Controls.Add(dynamicLabel);

        }
    }
}







