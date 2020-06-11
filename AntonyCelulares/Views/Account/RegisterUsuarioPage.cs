﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AntonyCelulares.Enums;
using AntonyCelulares.Interfaces;

namespace AntonyCelulares.Views.Account
{
    public partial class RegisterUsuarioPage : Form,IUsuario
    {
        #region Properties
        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }
        public string Username
        {
            get => txtUsername.Text;
            set => txtUsername.Text = value;
        }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public Guid Id { get; set; }
        public string Nombre { get => txtNombre.Text; set => txtNombre.Text = value; }
        public string Apellido { get => txtApellido.Text; set => txtApellido.Text=value; }
        public string Documento { get => txtDocument.Text; set => txtDocument.Text=value; }
        public string Direccion { get => txtDireccion.Text; set => txtDireccion.Text = value; }
        public string Telefono { get => txtTelefono.Text; set => txtTelefono.Text=value; }
       
        public UserType Rol 
        {
            get => (UserType)cbUserTypes.SelectedIndex;
            set => cbUserTypes.SelectedIndex = (int)value; 
        }
        public Image Avatar { get => pbAvatar.Image; set => pbAvatar.Image=value; }

        #endregion
        #region Contructors
        public RegisterUsuarioPage()
        {
            InitializeComponent();
            Id = Guid.Empty;
        }
        public RegisterUsuarioPage(IUsuario user)
        {
            InitializeComponent();
            Id = user.Id;
        }

        #endregion

        #region Methods

        private void btnSearchImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog(this)== DialogResult.OK)
            {
                Avatar = Bitmap.FromFile(openFileDialog.FileName);          
            }
        } 

        #endregion
    }
}
