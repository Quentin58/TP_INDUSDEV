﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_INDUSDEV.UserControls
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            Controls.Add(new UcUpdateTicket(2));
        }
    }
}
