using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albanian_Virus
{
	class Program
	{
		static void Main(string[] args)
		{
            var result = MessageBox.Show("Hi, I am an Albanian virus but because of poor technology in my country, unfortunately I am not able to harm your computer. Please be so kind to delete one of your important files yourself and then forward me to other users. Many thanks for your cooperation! Best regards, Albanian virus","Virus Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if(result == DialogResult.No){
                MessageBox.Show("You are very mean","Virus Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(result == DialogResult.Yes){
                MessageBox.Show("Thank you very much","Virus Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
	}
}