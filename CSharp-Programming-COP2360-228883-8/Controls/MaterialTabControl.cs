using CSharp_Programming_COP2360_228883_8.MaterialDesign;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Programming_COP2360_228883_8.Controls
{
    public class MaterialTabControl : TabControl, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }
}
