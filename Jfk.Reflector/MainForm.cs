namespace Jfk.Reflector
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;
    using Jfk.Prism;


#pragma warning disable IDE1006 // Naming Styles
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event receivers.")]
    public partial class MainForm : Form
    {
        
        private Assembly assembly;
        MethodInfo methodInfo;
        Type type;
        object result;
        object classInstance;


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
            using (var openAssemblyDialog = new OpenFileDialog())
            {
                openAssemblyDialog.Multiselect = false;
                openAssemblyDialog.Filter = @"exe|*.exe|dll|*.dll";
                openAssemblyDialog.RestoreDirectory = true;
                if (openAssemblyDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                this.assembly = Assembly.LoadFrom(openAssemblyDialog.FileName);
                type = assembly.GetType("JFKTest.Testowa");
                this.PopulateTree();
            }
        }

        private void PopulateTree()
        {
            this.assemblyTreeView.Nodes.Clear();
            var newNode = new TreeNode(this.assembly.GetName().Name) { Tag = this.assembly };
            this.assemblyTreeView.Nodes.Add(newNode);

            foreach (var module in this.assembly.GetModules())
            {
                AddModule(module, newNode);
            }
        }

        private void memberNode_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (assemblyTreeView.SelectedNode.Tag is MemberInfo tmpMethod)
            {
                methodInfo = type.GetMethod(assemblyTreeView.SelectedNode.Name);
                
                if (tmpMethod.GetCustomAttribute<Jfk.Prism.DescriptionAttribute>(true) != null)
                {
                    Descpription.Text = tmpMethod.GetCustomAttribute<Jfk.Prism.DescriptionAttribute>(true).Description;
                }

                else
                {
                    Descpription.Text = "Wybierz wlasciwa funkcje.";
                }
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
            if (Activator.CreateInstance(type) is ICallable callable)
            {
                int arg1 = 0b00000000;
                int arg2 = 0b00000000;
                int wynik = 0;
                string wynikbit;

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

                object[] parameters = new object[2];
                parameters[0] = arg1;
                parameters[1] = arg2;

                result = methodInfo.Invoke(callable, parameters);
                wynik = (int)result;
                wynikbit = Convert.ToString(wynik, 2);

                
                wyniktext.Text = "Wynik = " + wynik;
                wynikbittext.Text = "Bit = 0b" + wynikbit;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program wykonał Damian TOMASIK na bazie programu Pana Mierzejewskiego." +
                " Program jest prostym kalkulatorem binarnym.");
        }
    }
#pragma warning restore IDE1006 // Naming Styles
}
