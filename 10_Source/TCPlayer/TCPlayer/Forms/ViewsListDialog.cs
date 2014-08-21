﻿#region Copyright (c) 2014 Leonid Lezner. All rights reserved.
// Copyright (C) 2013-2014 Leonid Lezner
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPlayer.Project;

namespace TCPlayer.Forms
{
    public partial class ViewsListDialog : Form
    {
        public TCProject Project { get; set; }

        public ViewsListDialog()
        {
            InitializeComponent();
        }

        private void ViewsListDialog_Load(object sender, EventArgs e)
        {
            foreach (DynView view in Project.ViewSet)
            {
                ListViewItem item = new ListViewItem();

                item.Text = view.Name;

                ListViewItem.ListViewSubItem itemIdent = new ListViewItem.ListViewSubItem();
                itemIdent.Text = view.Ident;
                item.SubItems.Add(itemIdent);

                ListViewItem.ListViewSubItem itemTitle = new ListViewItem.ListViewSubItem();
                itemTitle.Text = view.Title;
                item.SubItems.Add(itemTitle);

                ListViewItem.ListViewSubItem itemVersion = new ListViewItem.ListViewSubItem();
                itemVersion.Text = view.Version.ToString();
                item.SubItems.Add(itemVersion);

                ListViewItem.ListViewSubItem itemAuthor = new ListViewItem.ListViewSubItem();
                itemAuthor.Text = view.Author;
                item.SubItems.Add(itemAuthor);

                listOfViews.Items.Add(item);
            }
        }
    }
}
