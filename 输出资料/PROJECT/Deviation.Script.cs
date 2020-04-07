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
    
    
    public partial class Deviation
    {
		//计算模块1负载电流偏差
		public void computeUnitOne() {
			float avg = (Globals.Tags.dis_ial.Value + Globals.Tags.dis_ibl.Value + Globals.Tags.dis_icl.Value) / 3.0;
			
			Globals.Tags.dev_dis_ial.Value = Math.Abs(Globals.Tags.dis_ial.Value - avg);
			Globals.Tags.dev_dis_ibl.Value = Math.Abs(Globals.Tags.dis_ibl.Value - avg);
			Globals.Tags.dev_dis_icl.Value = Math.Abs(Globals.Tags.dis_icl.Value - avg);

			if (Globals.Tags.dev_dis_ial.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl.Value >= Globals.Tags.F1_D_H.Value) {
				Globals.Tags.F1_DS_H.Value = 1;
			} else {
				Globals.Tags.F1_DS_H.Value = 0;
			}
		}

		//计算模块2负载电流偏差
		public void computeUnitTwo() {
			float avg = (Globals.Tags.dis_ial_f2.Value + Globals.Tags.dis_ibl_f2.Value + Globals.Tags.dis_icl_f2.Value) / 3.0;
			
			Globals.Tags.dev_dis_ial_f2.Value = Math.Abs(Globals.Tags.dis_ial_f2.Value - avg);
			Globals.Tags.dev_dis_ibl_f2.Value = Math.Abs(Globals.Tags.dis_ibl_f2.Value - avg);
			Globals.Tags.dev_dis_icl_f2.Value = Math.Abs(Globals.Tags.dis_icl_f2.Value - avg);

			if (Globals.Tags.dev_dis_ial_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl_f2.Value >= Globals.Tags.F1_D_H.Value) {
				Globals.Tags.F2_DS_H.Value = 1;
			} else {
				Globals.Tags.F2_DS_H.Value = 0;
			}
		}
		
		void Deviation_Created(System.Object sender, System.EventArgs e)
		{
			//开机时设定系统语言
			if (Globals.Tags.LID.Value>0 && Globals.Tags.LID.Value <4) {
				Globals.Tags.LID.Value--;
			}
		}
    }
}
