﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;
using BL;
using NS_WCF_Peds;

namespace App
{
    public partial class FrmUsrs : Form
    {
        public FrmUsrs()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            NS_WCF_AccesosRolesUsrs.Srv_wcf_AccesosRolesUsrs xwcf = new NS_WCF_AccesosRolesUsrs.Srv_wcf_AccesosRolesUsrs();
            ClsBL_Usr obj_BLusr = new ClsBL_Usr();
            xwcf.Insertar_Usuario(new ClsUsuario(txtUsuario.Text, txtClave.Text, txtNombres.Text, txtApellidos.Text,"_"));

        }

        public void _GetDatoss() { }
    }
}
