using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalhaBayrakcıProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet11.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet11.ORDER);
            // TODO: Bu kod satırı 'dataSet1.BİLL' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);
            // TODO: Bu kod satırı 'dataSet1.ORDER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
            // TODO: Bu kod satırı 'dataSet1.MANAGMENT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mANAGMENTTableAdapter.Fill(this.dataSet1.MANAGMENT);
            // TODO: Bu kod satırı 'dataSet1.CUSTOMER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            // TODO: Bu kod satırı 'dataSet1.CARS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cARSTableAdapter.Fill(this.dataSet1.CARS);
            // TODO: Bu kod satırı 'dataSet1.GALARY' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gALARYTableAdapter.Fill(this.dataSet1.GALARY);

        }

        private void button1_Click(object sender, EventArgs e)//İNSERT CUSTOMER
        {
            int C_Number, M_ID;
            int.TryParse(textBox3.Text, out C_Number);
            int.TryParse(comboBox1.SelectedValue.ToString(), out M_ID);
            this.cUSTOMERTableAdapter.InsertQuery(textBox1.Text, textBox2.Text,C_Number,textBox4.Text, M_ID);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void button3_Click(object sender, EventArgs e)//UPDATE CUSTOMER
        {
            int ID, NUMBER, MANAGMENT;
            int.TryParse(textBox5.Text, out ID);
            int.TryParse(textBox8.Text, out NUMBER);
            int.TryParse(comboBox2.SelectedValue.ToString(), out MANAGMENT);
            this.cUSTOMERTableAdapter.UpdateQuery(textBox6.Text, textBox7.Text, NUMBER, textBox9.Text, MANAGMENT,ID);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);

        }

        private void button2_Click(object sender, EventArgs e)//search customer
        {
            int C_ID;
            int.TryParse(textBox5.Text, out C_ID);
            textBox6.Text = this.cUSTOMERTableAdapter.ScalarQuery_FName(C_ID);
            textBox7.Text = this.cUSTOMERTableAdapter.ScalarQuery_LName(C_ID);
            textBox8.Text = Convert.ToString(this.cUSTOMERTableAdapter.ScalarQuery_Number(C_ID));
            textBox9.Text = this.cUSTOMERTableAdapter.ScalarQuery_Address(C_ID);
        }

        private void button4_Click(object sender, EventArgs e)//Delete customer 
        {
            int C_ID;
            int.TryParse(textBox5.Text, out C_ID);
            this.cUSTOMERTableAdapter.DeleteQuery(C_ID);
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
        }

        private void button5_Click(object sender, EventArgs e)// managment insert
        {
            int M_ID, M_Number;
            int.TryParse(textBox14.Text, out M_ID);
            int.TryParse(textBox12.Text, out M_Number);
            this.mANAGMENTTableAdapter.InsertQuery(textBox10.Text, textBox11.Text, M_Number, textBox13.Text, M_ID);
            this.mANAGMENTTableAdapter.Fill(this.dataSet1.MANAGMENT);
        
        }

        private void button7_Click(object sender, EventArgs e)//Managment update
        {
            int ID, Number, G_ID;
            int.TryParse(textBox14.Text, out ID);
            int.TryParse(textBox17.Text, out Number);
            int.TryParse(comboBox3.SelectedValue.ToString(), out G_ID);
            this.mANAGMENTTableAdapter.UpdateQuery(textBox15.Text, textBox16.Text, Number, textBox18.Text, G_ID, ID);
            this.mANAGMENTTableAdapter.Fill(this.dataSet1.MANAGMENT);
        }

        private void button6_Click(object sender, EventArgs e)// search managment 
        {
            int M_ID;
            int.TryParse(textBox14.Text, out M_ID);
            textBox15.Text = this.mANAGMENTTableAdapter.ScalarQuery_FName(M_ID);
            textBox16.Text = this.mANAGMENTTableAdapter.ScalarQuery_LName(M_ID);
            textBox17.Text = Convert.ToString(this.mANAGMENTTableAdapter.ScalarQuery_Number(M_ID));
            textBox18.Text = this.mANAGMENTTableAdapter.ScalarQuery_Address(M_ID);
        
        }

        private void button8_Click(object sender, EventArgs e)//DELETE MANAGMENT
        {
            int M_ID;
            int.TryParse(textBox14.Text, out M_ID);
            this.mANAGMENTTableAdapter.DeleteQuery(M_ID);
            this.mANAGMENTTableAdapter.Fill(this.dataSet1.MANAGMENT);
        }

        private void button9_Click(object sender, EventArgs e)//insert car
        {
            int CAR_ID, Q_ID, P_ID, G_ID;
            int.TryParse(textBox24.Text, out CAR_ID);
            int.TryParse(textBox21.Text, out Q_ID);
            int.TryParse(textBox23.Text, out P_ID);
            int.TryParse(comboBox5.SelectedValue.ToString(), out G_ID);
            this.cARSTableAdapter.InsertQuery(textBox19.Text, textBox20.Text, Q_ID, textBox22.Text, P_ID, G_ID);
            this.cARSTableAdapter.Fill(this.dataSet1.CARS);

        }

        private void button11_Click(object sender, EventArgs e)//update car
        {
            int CAR_ID, Q_ID, P_ID, G_ID; ;
            int.TryParse(textBox24.Text, out CAR_ID);
            int.TryParse(textBox27.Text, out Q_ID);
            int.TryParse(textBox29.Text, out P_ID);
            int.TryParse(comboBox6.SelectedValue.ToString(), out G_ID);
            this.cARSTableAdapter.UpdateQuery(textBox25.Text, textBox26.Text, Q_ID, textBox28.Text, P_ID, G_ID, CAR_ID);
            this.cARSTableAdapter.Fill(this.dataSet1.CARS);

        }

        private void button10_Click(object sender, EventArgs e)//search car
        {
            int CAR_ID;
            int.TryParse(textBox24.Text, out CAR_ID);
            textBox25.Text = this.cARSTableAdapter.ScalarQuery_MARK(CAR_ID);
            textBox26.Text = this.cARSTableAdapter.ScalarQuery_MODEL(CAR_ID);
            textBox27.Text = Convert.ToString(this.cARSTableAdapter.ScalarQuery_QUANTİTY(CAR_ID));
            textBox28.Text = this.cARSTableAdapter.ScalarQuery_COLOR(CAR_ID);
            textBox29.Text = Convert.ToString(this.cARSTableAdapter.ScalarQuery_PRİCE(CAR_ID));

        }

        private void button12_Click(object sender, EventArgs e)//delete  car
        {
            int CAR_ID;
            int.TryParse(textBox24.Text, out CAR_ID);
            this.cARSTableAdapter.DeleteQuery(CAR_ID);
            this.cARSTableAdapter.Fill(this.dataSet1.CARS);

        }

        private void button13_Click(object sender, EventArgs e)// İNSERT GALARY
        {
            int G_ID, G_NUMBER;
            int.TryParse(textBox33.Text, out G_ID);
            int.TryParse(textBox31.Text, out G_NUMBER);
            this.gALARYTableAdapter.InsertQuery(textBox30.Text, G_NUMBER, textBox32.Text);
            this.gALARYTableAdapter.Fill(this.dataSet1.GALARY);
        }

        private void button15_Click(object sender, EventArgs e)//UPDATE GALARY
        {
            int G_ID, G_NUMBER;
            int.TryParse(textBox33.Text, out G_ID);
            int.TryParse(textBox35.Text, out G_NUMBER);
            this.gALARYTableAdapter.UpdateQuery(textBox34.Text, G_NUMBER, textBox36.Text, G_ID);
            this.gALARYTableAdapter.Fill(this.dataSet1.GALARY);


        }

        private void button14_Click(object sender, EventArgs e)//search galary
        {
            int G_ID;
            int.TryParse(textBox33.Text, out G_ID);
            textBox34.Text = this.gALARYTableAdapter.ScalarQuery_NAME(G_ID);
            textBox35.Text = Convert.ToString(this.gALARYTableAdapter.ScalarQuery_NUMBER(G_ID));
            textBox36.Text = this.gALARYTableAdapter.ScalarQuery_ADDRESS(G_ID);
        }

        private void button16_Click(object sender, EventArgs e)//delete galary
        {
            int G_ID;
            int.TryParse(textBox33.Text, out G_ID);
            this.gALARYTableAdapter.DeleteQuery(G_ID);
            this.gALARYTableAdapter.Fill(this.dataSet1.GALARY);
        }

        private void button17_Click(object sender, EventArgs e)//insert order
        {
            int C_ID, CAR_ID;
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            int.TryParse(comboBox7.SelectedValue.ToString(), out C_ID);
            int.TryParse(comboBox8.SelectedValue.ToString(), out CAR_ID);
            this.oRDERTableAdapter.InsertQuery(C_ID, CAR_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);
        }

        private void button19_Click(object sender, EventArgs e)// update order
        {
            int ORDER_ID, C_ID, CAR_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            int.TryParse(comboBox9.SelectedValue.ToString(), out C_ID);
            int.TryParse(comboBox10.SelectedValue.ToString(), out CAR_ID);
            this.oRDERTableAdapter.UpdateQuery(C_ID, CAR_ID, ORDER_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);


        }

        private void button18_Click(object sender, EventArgs e)//SEARCH ORDER
        {
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            comboBox9.SelectedValue = Convert.ToString(this.oRDERTableAdapter.ScalarQuery_CUSTOMER(ORDER_ID));
            comboBox10.SelectedValue = Convert.ToString(this.oRDERTableAdapter.ScalarQuery_CAR(ORDER_ID));
            
                
        }

        private void button20_Click(object sender, EventArgs e)//delete order
        {
            int ORDER_ID;
            int.TryParse(textBox38.Text, out ORDER_ID);
            this.oRDERTableAdapter.DeleteQuery(ORDER_ID);
            this.oRDERTableAdapter.Fill(this.dataSet1.ORDER);

        }

        private void button21_Click(object sender, EventArgs e)//insert bill 
        {
            int BİLL_ID, ORDER_ID;
            int.TryParse(textBox40.Text, out BİLL_ID);
            int.TryParse(comboBox11.SelectedValue.ToString(), out ORDER_ID);
            this.bİLLTableAdapter.InsertQuery(ORDER_ID);
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);

        }

        private void button22_Click(object sender, EventArgs e)//search bill
        {
            int BİLL_ID;
            int.TryParse(textBox40.Text, out BİLL_ID);
            comboBox11.SelectedValue = Convert.ToString(this.bİLLTableAdapter.ScalarQuery_ORDER(BİLL_ID));

        }

        private void button23_Click(object sender, EventArgs e)
        {
            int BİLL_ID;
            int.TryParse(textBox40.Text, out BİLL_ID);
            this.bİLLTableAdapter.DeleteQuery(BİLL_ID);
            this.bİLLTableAdapter.Fill(this.dataSet1.BİLL);

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            int G_ID;
            int.TryParse(textBox33.Text, out G_ID);
            this.gALARYTableAdapter.DeleteQuery(G_ID);
            this.gALARYTableAdapter.Fill(this.dataSet1.GALARY);
        }
    }
}
