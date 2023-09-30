using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        double number1, number2;
        string btnClicked = "";

        public Form1() {
            InitializeComponent();

        }

        public void clearText() {
            this.txtNum1.Text = string.Empty;
            this.txtNum2.Text = string.Empty;
            this.lblResultValue.Text = string.Empty;
        }

        public double getNum1() {
            number1 = Convert.ToDouble(txtNum1.Text);
            return number1;
        }

        public double getNum2() {
            number2 = Convert.ToDouble(txtNum2.Text);

            return number2;
        }
        public double add() {
            return getNum1() + getNum2();
        }

        public double subtract() {
            return getNum1() - getNum2();
        }

        public double multiply() {
            return getNum1() * getNum2();
        }
        public double divide() {
            return getNum1() / getNum2();
        }
        public void calculateResult(string btnClicked) {
            try {
                switch (btnClicked) {
                    case "+": {
                        this.lblResultValue.Text = add().ToString();
                        break;
                    }
                    case "-": {
                        this.lblResultValue.Text = subtract().ToString();
                        break;
                    }
                    case "x": {
                        this.lblResultValue.Text = multiply().ToString();
                        break;
                    }
                    case "/": {
                        this.lblResultValue.Text = divide().ToString();
                        break;
                    }
                }
            } catch (Exception) {
                this.lblResultValue.Text = "Invalid input";
                this.lblResultValue.ForeColor = Color.Red;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e) {
            btnClicked = "+";
            calculateResult(btnClicked);
        }

        private void btnSubtract_Click_1(object sender, EventArgs e) {
            btnClicked = "-";
            calculateResult(btnClicked);
        }

        private void btnMultiply_Click_1(object sender, EventArgs e) {
            btnClicked = "x";
            calculateResult(btnClicked);
        }

        private void btnDivide_Click_1(object sender, EventArgs e) {
            btnClicked = "/";
            calculateResult(btnClicked);
        }

        private void btnClear_Click(object sender, EventArgs e) {
            clearText();
        }
    }
}
