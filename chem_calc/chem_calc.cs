using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chem_calc
{
    public partial class chem_calc : Form
    {

        //화합물 클래스
        class EQ
        {
	        public string Reagent = string.Empty; //물질
            public string CAS_NUM = string.Empty; //화합물 번호

            public double mw = 0;      //분장량
            public double eq = 0;      //당량
            public double mol = 0;     //몰수
            public double weight = 0;  //질량
            public double density = 0; //밀도
            public double Molarity = 0;//몰농도
            public double vol = 0;     //부피

            //public void calculate()
        };

        EQ[] EQ_list;
        int size = 6;

        //for(int i = 0;i < size; ++i)
        //{
            
        //}


        //화합물 관리 클래스
        //class EQ_Management
        //{

        //    public EQ[] EQ_list;
        //    public int index = 0;

        //    public void addEQ(int index)
        //    {
        //        if(EQ_list[index] == null)//null 체크 후 클래스 추가
        //        {
        //            EQ_list[index] = new EQ();
        //        }
        //    }
        //    public void calculate(int index)
        //    {
                
        //    }
        //}

        public chem_calc()
        {
            InitializeComponent();
        }

        private void tb_chem0_Reagent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EQ_list[0].Reagent = tb_chem0_Reagent.Text;
            }
        }

        private void tb_chem_CASNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].CAS_NUM = tb_chem0_CASNum.Text;
            }
        }

        private void tb_chem0_mw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].mw = double.Parse(tb_chem0_mw.Text);
            }
        }

        private void tb_chem0_eq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].eq = double.Parse(tb_chem0_eq.Text);
            }
        }

        private void tb_chem0_mol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].mol = double.Parse(tb_chem0_mol.Text);
            }
        }

        private void tb_chem0_weight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].weight = double.Parse(tb_chem0_weight.Text);
            }
        }

        private void tb_chem0_density_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].density = double.Parse(tb_chem0_density.Text);
            }
        }

        private void tb_chem0_Molarity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].Molarity = double.Parse(tb_chem0_Molarity.Text);
            }
        }

        private void tb_chem0_vol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EQ_list[0].vol = double.Parse(tb_chem0_vol.Text);
            }
        }
    }
}
