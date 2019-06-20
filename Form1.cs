using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlGenerator;

namespace TextGenerator
{
    public partial class Form1 : Form
    {
        public string[] ServiceTypes = 
        {
            "SERVICE_TYPE_1",
            "SERVICE_TYPE_2",
            "SERVICE_TYPE_3",
            "SERVICE_TYPE_4",
            "SERVICE_TYPE_5"
        };

        public string[] BaseValueTypes =
        {
            "BASE_VALUE_TYPE_1",
            "BASE_VALUE_TYPE_2",
            "BASE_VALUE_TYPE_3",
            "BASE_VALUE_TYPE_4",
            "BASE_VALUE_TYPE_6",
            "BASE_VALUE_TYPE_7",
            "BASE_VALUE_TYPE_8",
            "BASE_VALUE_TYPE_9",
            "BASE_VALUE_TYPE_10",
            "BASE_VALUE_TYPE_11",
            "BASE_VALUE_TYPE_12",
        };

        public bool[] Permissable = new bool[]
        {
            true,
            false
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 1000; i++)
            {
                Insert insert = new Insert
                {
                    Table = new Table("dbo.PermissableUse"),
                    Parameters = new List<SqlParameter>
                    {
                        new SqlParameter("Created", DateTime.Now),
                        new SqlParameter("CreatedBy", "Matthew.Shoemaker"),
                        new SqlParameter("Updated", DateTime.Now),
                        new SqlParameter("UpdatedBy", "Matthew.Shoemaker"),
                        new SqlParameter("ServiceType", ServiceTypes[Random(0, ServiceTypes.Length - 1)]),
                        new SqlParameter("BaseValueType", BaseValueTypes[Random(0, BaseValueTypes.Length - 1)]),
                        new SqlParameter("Basevalue", $"BaseValue_{i}"),
                        new SqlParameter("Permissable", Permissable[Random(0,2)])
                    }
                };
                result += insert.ToString() + Environment.NewLine + Environment.NewLine;
            }

            new TextWriter().Write(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), result);
        }

        private int Random(int min, int max)
        {
            Random random = new Random();
            int result = random.Next(min, max);

            return result;
        }
    }
}
