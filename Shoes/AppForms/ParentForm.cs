using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.AppModels;
using Shoes.AppService;

namespace Shoes
{
    public partial class ParentForm : Form
    {        
        
        public ParentForm()
        {   
            InitializeComponent();
            ContextManager.parentForm = this;            
        }

        public void setFullName(string fullName) {
            this.fullName.Text = fullName;
        }
    }
}
