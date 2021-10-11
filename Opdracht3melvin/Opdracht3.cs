using System;
using System.Windows.Forms;

namespace Opdracht3melvin
{
    public partial class Opdracht3 : Form
    {
        Stapel<int> intStapel = new();
        Stapel<string> stringStapel = new();
        Stapel<Person> persoonStapel = new();
        bool persoonVeranderd = false;
        public Opdracht3()
        {
            InitializeComponent();
        }

        private bool IsEveritingADigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        private void toevoegenInt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(intBox.Text) == false && IsEveritingADigit(intBox.Text))
            {
                intStapel.Toevoegen(int.Parse(intBox.Text));
            }
        }

        private void toevoegenString_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stringBox.Text) == false)
            {
                stringStapel.Toevoegen(stringBox.Text);
            }
        }

        private void toevoegenObject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(objectNaamBox.Text) == false && string.IsNullOrWhiteSpace(objectLeeftijdBox.Text) == false && IsEveritingADigit(objectLeeftijdBox.Text))
            {
                persoonStapel.Toevoegen(new Person(objectNaamBox.Text, int.Parse(objectLeeftijdBox.Text)));
            }
        }

        private void verwijderenInt_Click(object sender, EventArgs e)
        {
            if (intStapel.ToString() != string.Empty)
            {
                intStapel.Verwijderen();
            }
            else
            {
                MessageBox.Show("Sorry maar de lijst is leeg");
            }
        }

        private void verwijderenString_Click(object sender, EventArgs e)
        {
            if (stringStapel.ToString() != string.Empty)
            {
                stringStapel.Verwijderen();
            }
            else
            {
                MessageBox.Show("Sorry maar de lijst is leeg");
            }
        }

        private void verwijderenObject_Click(object sender, EventArgs e)
        {
            if (persoonStapel.ToString() != string.Empty)
            {
                persoonStapel.Verwijderen();
            }
            else
            {
                MessageBox.Show("Sorry maar de lijst is leeg");
            }
        }

        private void leegmakenInt_Click(object sender, EventArgs e)
        {
            intStapel.Leegmaken();
        }

        private void leegmakenString_Click(object sender, EventArgs e)
        {
            stringStapel.Leegmaken();
        }

        private void leegmakenObject_Click(object sender, EventArgs e)
        {
            persoonStapel.Leegmaken();
        }

        private void toStringInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(intStapel.ToString());
        }

        private void toStringString_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringStapel.ToString());
        }

        private void toStringObject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persoonStapel.ToString());
        }

        private void isAanwezigInt_Click(object sender, EventArgs e)
        {
            string show = "Error!!!!!! Input is slecht ingevuld";
            if (string.IsNullOrWhiteSpace(intBox.Text) == false && IsEveritingADigit(intBox.Text))
            {
                show = int.Parse(intBox.Text) + " bestaat niet in de list";
                if (intStapel.IsAanwezig(int.Parse(intBox.Text)))
                {
                    show = int.Parse(intBox.Text) + " bestaat in de list";
                }
            }

            MessageBox.Show(show);
        }

        private void isAanwezigString_Click(object sender, EventArgs e)
        {
            string show = "Error!!!!!! Input is slecht ingevuld";
            if (string.IsNullOrWhiteSpace(intBox.Text) == false)
            {
                show = stringBox.Text + " bestaat niet in de list";
                if (stringStapel.IsAanwezig(stringBox.Text))
                {
                    show = stringBox.Text + " bestaat in de list";
                }
            }

            MessageBox.Show(show);
        }

        private void isAanwezigObject_Click(object sender, EventArgs e)
        {
            string show = "Error!!!!!! Input is slecht ingevuld";
            if (string.IsNullOrWhiteSpace(objectLeeftijdBox.Text) == false &&
                IsEveritingADigit(objectLeeftijdBox.Text) &&
                string.IsNullOrWhiteSpace(objectNaamBox.Text) == false)
            {
                show = objectNaamBox.Text + "; " + int.Parse(objectLeeftijdBox.Text) + "; bestaat niet in de list";
                if (
                    persoonStapel.IsAanwezig(new Person(objectNaamBox.Text, int.Parse(objectLeeftijdBox.Text)))
                    )
                {
                    show = objectNaamBox.Text + "; " + int.Parse(objectLeeftijdBox.Text) + "; bestaat in de list";
                }
            }

            MessageBox.Show(show);
        }

        private void copyInt_Click(object sender, EventArgs e)
        {
            intStapel.StapelCopy();
            MessageBox.Show("Old list: " + intStapel.ToString() + "\n New list: " + 
                String.Join("; ", intStapel.StapelCopy()));
        }

        private void copyString_Click(object sender, EventArgs e)
        {
            stringStapel.StapelCopy();
            MessageBox.Show("Old list: " + stringStapel.ToString() + "\n New list: " + 
                String.Join("; ", stringStapel.StapelCopy()));
        }

        private void copyObject_Click(object sender, EventArgs e)
        {
            persoonStapel.StapelCopy();
            MessageBox.Show("Old list: " + persoonStapel.ToString() + "\n New list: " +
                String.Join("; ", persoonStapel.StapelCopy()));
        }
    }
}
