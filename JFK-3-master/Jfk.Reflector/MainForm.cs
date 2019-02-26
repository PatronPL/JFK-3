namespace Jfk.Reflector
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using Jfk.Prism;


#pragma warning disable IDE1006 // Naming Styles
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event receivers.")]
    public partial class MainForm : Form
    {

        private Assembly assembly;

        object result;



        public MainForm()
        {
            this.InitializeComponent();
        }

        private static void AddModule(Module module, TreeNode parent)
        {
            var newNode = new TreeNode(module.Name) { Tag = module };
            parent.Nodes.Add(newNode);

            foreach (var type in module.GetTypes())
            {
                AddType(type, newNode);
            }
        }

#pragma warning disable CC0021 // Use nameof
        private static void AddType(Type type, TreeNode parent)
        {
            var newNode = new TreeNode(type.Name) { Tag = type };
            TreeNode memberNode;

            var memberTypeNode = new TreeNode("Methods");
            foreach (var method in type.GetMethods())
            {
                var count = method.GetParameters().Length;
                var stringBuilder = new StringBuilder(method.Name).Append('(');
                foreach (var param in method.GetParameters())
                {
                    stringBuilder.Append(param.ParameterType);
                    if (param.Position < count - 1)
                    {
                        stringBuilder.Append(", ");
                    }
                }

                stringBuilder.Append(')');
                memberNode = new TreeNode(stringBuilder.ToString()) { Tag = method };
                memberNode.Name = method.Name;
                memberTypeNode.Nodes.Add(memberNode);
            }

            newNode.Nodes.Add(memberTypeNode);


            parent.Nodes.Add(newNode);
        }
#pragma warning restore CC0021 // Use nameof

        private void openFileStripItem_Click(object sender, EventArgs e)
        {
            assemblyTreeView.Nodes.Clear();
            
            Descpription.Text = string.Empty;
            wyniktext.Text = string.Empty;

            string[] files = null;

            using (var folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    files = Directory.GetFiles(folder.SelectedPath);
                }
            }

            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.EndsWith("dll") || file.EndsWith("exe"))
                    {
                        assembly = Assembly.LoadFile(file);
                        PopulateTree();
                    }
                }
            }
        }

        private void PopulateTree()
        {
            
            var newNode = new TreeNode(this.assembly.GetName().Name) { Tag = this.assembly };
            this.assemblyTreeView.Nodes.Add(newNode);

            foreach (var module in this.assembly.GetModules())
            {
                AddModule(module, newNode);
            }
        }

        private void memberNode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Descpription.Text = string.Empty;
            wyniktext.Text = string.Empty;
            wynikbittext.Text = string.Empty;

            if (assemblyTreeView.SelectedNode?.Tag is Type selectClass)
            {
                if (selectClass.GetCustomAttribute<DescriptionAttribute>(true) != null)
                {
                    Descpription.Text = selectClass.GetCustomAttribute<DescriptionAttribute>(true).Description;
                }
                else
                {
                    Descpription.Text = string.Empty;
                }
            }
            else
            {
                Descpription.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bit0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (assemblyTreeView?.SelectedNode != null)
            {
                var typ = assemblyTreeView.SelectedNode.Tag as Type;

                if (typeof(ICallable).IsAssignableFrom(typ))
                {
                    if (Activator.CreateInstance(typ) is ICallable callable)
                    {
                        int arg1 = 0b00000000;
                        int arg2 = 0b00000000;
                        int wynik = 0;
                        string wynikbit;
                        if (!inputStyle.Checked)
                        {
                            if (bit0.Checked)
                                arg1 += 0b00000001;
                            if (bit1.Checked)
                                arg1 += 0b00000010;
                            if (bit2.Checked)
                                arg1 += 0b00000100;
                            if (bit3.Checked)
                                arg1 += 0b00001000;
                            if (bit4.Checked)
                                arg1 += 0b00010000;
                            if (bit5.Checked)
                                arg1 += 0b00100000;
                            if (bit6.Checked)
                                arg1 += 0b01000000;
                            if (bit7.Checked)
                                arg1 += 0b10000000;

                            if (bit0a.Checked)
                                arg2 += 0b00000001;
                            if (bit1a.Checked)
                                arg2 += 0b00000010;
                            if (bit2a.Checked)
                                arg2 += 0b00000100;
                            if (bit3a.Checked)
                                arg2 += 0b00001000;
                            if (bit4a.Checked)
                                arg2 += 0b00010000;
                            if (bit5a.Checked)
                                arg2 += 0b00100000;
                            if (bit6a.Checked)
                                arg2 += 0b01000000;
                            if (bit7a.Checked)
                                arg2 += 0b10000000;
                        }
                        else
                        {
                            int.TryParse(textArgument1.Text, out arg1);
                            int.TryParse(textArgument2.Text, out arg2);
                            if (textBit1.Text == "Wprowadz liczbe calkowita" || textBit2.Text == "Wprowadz liczbe calkowita")
                            {
                                wyniktext.Text = "Wprowadz liczby calkowite";
                                wynikbittext.Text = "Wprowadz liczby calkowite";
                                return;
                            }
                                
                        }

                        result = callable.Call(arg1,arg2);
                        wynik = (int)result;
                        wynikbit = Convert.ToString(wynik, 2);


                        wyniktext.Text = "Wynik = " + wynik;
                        wynikbittext.Text = "Bit = 0b" + wynikbit;
                    }


                }

                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program wykonał Damian TOMASIK na bazie programu Pana Mierzejewskiego." +
                "\n Program jest prostym kalkulatorem binarnym." +
                "\n Tryb wprowadzania można zmienić odchaczając ''input style''. ");
        }

        private void inputStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (inputStyle.Checked)
            {
                bool tf = false;
                label1.Enabled = tf;
                label1.Visible = tf;
                label2.Enabled = tf;
                label2.Visible = tf;
                label3.Enabled = tf;
                label3.Visible = tf;
                label4.Enabled = tf;
                label4.Visible = tf;
                textArgument1.Enabled = !tf;
                textArgument1.Visible = !tf;
                textArgument2.Enabled = !tf;
                textArgument2.Visible = !tf;
                textBit1.Enabled = !tf;
                textBit1.Visible = !tf;
                textBit2.Enabled = !tf;
                textBit2.Visible = !tf;
                bit0.Visible = tf;
                bit0.Enabled = tf;
                bit1.Visible = tf;
                bit1.Enabled = tf;
                bit2.Visible = tf;
                bit2.Enabled = tf;
                bit3.Visible = tf;
                bit3.Enabled = tf;
                bit4.Visible = tf;
                bit4.Enabled = tf;
                bit5.Visible = tf;
                bit5.Enabled = tf;
                bit6.Visible = tf;
                bit6.Enabled = tf;
                bit7.Visible = tf;
                bit7.Enabled = tf;

                bit0a.Visible = tf;
                bit0a.Enabled = tf;
                bit1a.Visible = tf;
                bit1a.Enabled = tf;
                bit2a.Visible = tf;
                bit2a.Enabled = tf;
                bit3a.Visible = tf;
                bit3a.Enabled = tf;
                bit4a.Visible = tf;
                bit4a.Enabled = tf;
                bit5a.Visible = tf;
                bit5a.Enabled = tf;
                bit6a.Visible = tf;
                bit6a.Enabled = tf;
                bit7a.Visible = tf;
                bit7a.Enabled = tf;
            }
            else
            {
                bool tf = true;
                label1.Enabled = tf;
                label1.Visible = tf;
                label2.Enabled = tf;
                label2.Visible = tf;
                label3.Enabled = tf;
                label3.Visible = tf;
                label4.Enabled = tf;
                label4.Visible = tf;
                textArgument1.Enabled = !tf;
                textArgument1.Visible = !tf;
                textArgument2.Enabled = !tf;
                textArgument2.Visible = !tf;
                textBit1.Enabled = !tf;
                textBit1.Visible = !tf;
                textBit2.Enabled = !tf;
                textBit2.Visible = !tf;
                bit0.Visible = tf;
                bit0.Enabled = tf;
                bit1.Visible = tf;
                bit1.Enabled = tf;
                bit2.Visible = tf;
                bit2.Enabled = tf;
                bit3.Visible = tf;
                bit3.Enabled = tf;
                bit4.Visible = tf;
                bit4.Enabled = tf;
                bit5.Visible = tf;
                bit5.Enabled = tf;
                bit6.Visible = tf;
                bit6.Enabled = tf;
                bit7.Visible = tf;
                bit7.Enabled = tf;

                bit0a.Visible = tf;
                bit0a.Enabled = tf;
                bit1a.Visible = tf;
                bit1a.Enabled = tf;
                bit2a.Visible = tf;
                bit2a.Enabled = tf;
                bit3a.Visible = tf;
                bit3a.Enabled = tf;
                bit4a.Visible = tf;
                bit4a.Enabled = tf;
                bit5a.Visible = tf;
                bit5a.Enabled = tf;
                bit6a.Visible = tf;
                bit6a.Enabled = tf;
                bit7a.Visible = tf;
                bit7a.Enabled = tf;
            }
        }

        private void textArgument1_TextChanged(object sender, EventArgs e)
        {
            int arg1;
            int.TryParse(textArgument1.Text, out arg1);
            textBit1.Text = Convert.ToString(arg1, 2);
            if (textBit1.Text == "0" && !int.TryParse(textArgument1.Text, out arg1))
                textBit1.Text = "Wprowadz liczbe calkowita";
        }

        private void textArgument2_TextChanged(object sender, EventArgs e)
        {
            int arg2;
            int.TryParse(textArgument2.Text, out arg2);
            textBit2.Text = Convert.ToString(arg2, 2);
            if (textBit2.Text == "0" && !int.TryParse(textArgument2.Text, out arg2))
                textBit2.Text = "Wprowadz liczbe calkowita";
        }
    }

#pragma warning restore IDE1006 // Naming Styles
}
