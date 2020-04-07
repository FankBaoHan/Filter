//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class Flicker
    {
		public void flick() {
			if (Globals.Tags.flickerState.Value == 1) {
				Globals.Tags.flicker.Value = !Globals.Tags.flicker.Value;
			}
		}

		public void ack() {
			bool hasAnyAlarms = (Globals.Tags.F1_VS_A_H.Value==1) || (Globals.Tags.F1_VS_A_L.Value==1) || (Globals.Tags.F1_FS_H.Value==1)
				|| (Globals.Tags.F1_FS_L.Value==1) || (Globals.Tags.F1_TS_H.Value==1) || (Globals.Tags.F1_CS_A_H.Value==1)
				|| (Globals.Tags.F1_CS_B_H.Value==1) || (Globals.Tags.F1_CS_C_H.Value==1) || (Globals.Tags.err1_11.Value==1)
				|| (Globals.Tags.err1_12.Value==1) || (Globals.Tags.err1_13.Value==1) || (Globals.Tags.F1_DS_H.Value==1)
				|| (Globals.Tags.F2_VS_A_H.Value==1) || (Globals.Tags.F2_VS_A_L.Value==1) || (Globals.Tags.F2_FS_H.Value==1)
				|| (Globals.Tags.F2_FS_L.Value==1) || (Globals.Tags.F2_TS_H.Value==1) || (Globals.Tags.F2_CS_A_H.Value==1)
				|| (Globals.Tags.F2_CS_B_H.Value==1) || (Globals.Tags.F2_CS_C_H.Value==1) || (Globals.Tags.err1_11_f2.Value==1)
				|| (Globals.Tags.err1_12_f2.Value==1) || (Globals.Tags.err1_13_f2.Value==1) || (Globals.Tags.F2_DS_H.Value==1);
			
			if (hasAnyAlarms) {
				Globals.Tags.flicker.Value = 1;
			} else {
				Globals.Tags.flicker.Value = 0;
			}
		}

		public void confirmAlarms() {
			if (Globals.Tags.flickerState.Value != 1) {
				ack();
			}
		}
    }
}
