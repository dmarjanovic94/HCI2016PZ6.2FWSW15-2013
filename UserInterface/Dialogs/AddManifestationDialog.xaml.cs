﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HCI_2016_Project.UserInterface.Dialogs
{
    /// <summary>
    /// Interaction logic for AddManifestationDialog.xaml
    /// </summary>
    /// 

    public partial class AddManifestationDialog : Window
    {
        public AddManifestationDialog()
        {
            InitializeComponent();

            Loaded += delegate
            {
                Tokenizer.Focus();
            };

            Tokenizer.TokenMatcher = text =>
            {
                if (text.EndsWith(" "))
                {
                    return text.Substring(0, text.Length - 1).Trim().ToLower();
                }

                return null;
            };
        }
    }
}
