﻿using System;
using System.Windows.Forms;

namespace Zektor {
    public partial class MainForm {
        public class SelectablePanel : Panel {
            // from https://stackoverflow.com/questions/3562235/panel-not-getting-focus
            public SelectablePanel() {
                this.SetStyle(ControlStyles.Selectable, true);
                this.TabStop = true;
            }
            protected override void OnMouseDown(MouseEventArgs e) {
                this.Focus();
                base.OnMouseDown(e);
            }
            protected override bool IsInputKey(Keys keyData) {
                if (keyData == Keys.Space || keyData == Keys.Enter) OnClick(EventArgs.Empty);
                if (keyData == Keys.Up || keyData == Keys.Down) return true;
                if (keyData == Keys.Left || keyData == Keys.Right) return true;
                return base.IsInputKey(keyData);
            }
            protected override void OnEnter(EventArgs e) {
                this.Invalidate();
                base.OnEnter(e);
            }
            protected override void OnLeave(EventArgs e) {
                this.Invalidate();
                base.OnLeave(e);
            }
            protected override void OnPaint(PaintEventArgs pe) {
                base.OnPaint(pe);
                if (this.Focused) {
                    var rc = this.ClientRectangle;
                    rc.Inflate(-2, -2);
                    ControlPaint.DrawFocusRectangle(pe.Graphics, rc);
                }
            }
        }

    }
}
