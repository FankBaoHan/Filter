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
    
    
	public partial class AlarmSet
	{
		Timer timer = new Timer();
		int[] arrayDelay = new int[18];
		
		void AlarmSet_Created(System.Object sender, System.EventArgs e)
		{
			timer.Tick += setAlarm;
			timer.Tick += commonAlarm;
			timer.Interval = 500;
			timer.Enabled = true;
		}
		
		void setAlarm(object sender, EventArgs e) {
			/*模块1*/
			
			//ABC电压高
			if ((Globals.Tags.dis_usa_173_f1.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usb_173_f1.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usc_173_f1.Value >= Globals.Tags.F1_V_H.Value)) {
				if (arrayDelay[0] >= 20) {
					Globals.Tags.F1_VS_A_H.Value = 1;
				} else {
					arrayDelay[0]++;
				}
			} else {
				arrayDelay[0] = 0;
				Globals.Tags.F1_VS_A_H.Value = 0;
			}
			//Globals.Tags.F1_VS_A_H.Value = (Globals.Tags.dis_usa_173_f1.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usb_173_f1.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usc_173_f1.Value >= Globals.Tags.F1_V_H.Value)?1:0;
			
			//ABC电压低
			if ((Globals.Tags.dis_usa_173_f1.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usb_173_f1.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usc_173_f1.Value <= Globals.Tags.F1_V_L.Value)) {
				if (arrayDelay[1] >= 20) {
					Globals.Tags.F1_VS_A_L.Value = 1;
				} else {
					arrayDelay[1]++;
				}
			} else {
				arrayDelay[1] = 0;
				Globals.Tags.F1_VS_A_L.Value = 0;
			}
			
			//Globals.Tags.F1_VS_A_L.Value = (Globals.Tags.dis_usa_173_f1.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usb_173_f1.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usc_173_f1.Value <= Globals.Tags.F1_V_L.Value)?1:0;
			
			//频率高低
			if ((Globals.Tags.freqvalue_measure.Value.Double >= Globals.Tags.F1_F_H.Value.Double)) {
				if (arrayDelay[2] >= 20) {
					Globals.Tags.F1_FS_H.Value = 1;
				} else {
					arrayDelay[2]++;
				}
			} else {
				arrayDelay[2] = 0;
				Globals.Tags.F1_FS_H.Value = 0;
			}
			
			//Globals.Tags.F1_FS_H.Value = (Globals.Tags.freqvalue_measure.Value.Double >= Globals.Tags.F1_F_H.Value.Double)?1:0;
			
			if ((Globals.Tags.freqvalue_measure.Value.Double <= Globals.Tags.F1_F_L.Value.Double)) {
				if (arrayDelay[3] >= 20) {
					Globals.Tags.F1_FS_L.Value = 1;
				} else {
					arrayDelay[3]++;
				}
			} else {
				arrayDelay[3] = 0;
				Globals.Tags.F1_FS_L.Value = 0;
			}
			
			//Globals.Tags.F1_FS_L.Value = (Globals.Tags.freqvalue_measure.Value.Double <= Globals.Tags.F1_F_L.Value.Double)?1:0;
			
			//温度高
			if ((Globals.Tags.dis_tem1.Value >= Globals.Tags.F1_T_H.Value)) {
				if (arrayDelay[4] >= 20) {
					Globals.Tags.F1_TS_H.Value = 1;
				} else {
					arrayDelay[4]++;
				}
			} else {
				arrayDelay[4] = 0;
				Globals.Tags.F1_TS_H.Value = 0;
			}
			
			//Globals.Tags.F1_TS_H.Value = (Globals.Tags.dis_tem1.Value >= Globals.Tags.F1_T_H.Value)?1:0;
			
			//ABC输出电流高,测试0.5秒
			if ((Globals.Tags.dis_iaf.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[5] >= 1) {
					Globals.Tags.F1_CS_A_H.Value = 1;
				} else {
					arrayDelay[5]++;
				}
			} else {
				arrayDelay[5] = 0;
				Globals.Tags.F1_CS_A_H.Value = 0;
			}
			
			if ((Globals.Tags.dis_ibf.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[6] >= 1) {
					Globals.Tags.F1_CS_B_H.Value = 1;
				} else {
					arrayDelay[6]++;
				}
			} else {
				arrayDelay[6] = 0;
				Globals.Tags.F1_CS_B_H.Value = 0;
			}
			
			if ((Globals.Tags.dis_icf.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[7] >= 1) {
					Globals.Tags.F1_CS_C_H.Value = 1;
				} else {
					arrayDelay[7]++;
				}
			} else {
				arrayDelay[7] = 0;
				Globals.Tags.F1_CS_C_H.Value = 0;
			}
			
			//Globals.Tags.F1_CS_A_H.Value = (Globals.Tags.dis_iaf.Value >= Globals.Tags.F1_C_H.Value)?1:0;
			//Globals.Tags.F1_CS_B_H.Value = (Globals.Tags.dis_ibf.Value >= Globals.Tags.F1_C_H.Value)?1:0;
			//Globals.Tags.F1_CS_C_H.Value = (Globals.Tags.dis_icf.Value >= Globals.Tags.F1_C_H.Value)?1:0;
			
			/*模块2*/
			
			//ABC电压高
			if ((Globals.Tags.dis_usa_173_f2.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usb_173_f2.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usc_173_f2.Value >= Globals.Tags.F1_V_H.Value)) {
				if (arrayDelay[8] >= 20) {
					Globals.Tags.F2_VS_A_H.Value = 1;
				} else {
					arrayDelay[8]++;
				}
			} else {
				arrayDelay[8] = 0;
				Globals.Tags.F2_VS_A_H.Value = 0;
			}
			
			
			//ABC电压低
			if ((Globals.Tags.dis_usa_173_f2.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usb_173_f2.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usc_173_f2.Value <= Globals.Tags.F1_V_L.Value)) {
				if (arrayDelay[9] >= 20) {
					Globals.Tags.F2_VS_A_L.Value = 1;
				} else {
					arrayDelay[9]++;
				}
			} else {
				arrayDelay[9] = 0;
				Globals.Tags.F2_VS_A_L.Value = 0;
			}
			
			//频率高低
			if ((Globals.Tags.freqvalue_measure_f2.Value.Double >= Globals.Tags.F1_F_H.Value.Double)) {
				if (arrayDelay[10] >= 20) {
					Globals.Tags.F2_FS_H.Value = 1;
				} else {
					arrayDelay[10]++;
				}
			} else {
				arrayDelay[10] = 0;
				Globals.Tags.F2_FS_H.Value = 0;
			}
			
			if ((Globals.Tags.freqvalue_measure_f2.Value.Double <= Globals.Tags.F1_F_L.Value.Double)) {
				if (arrayDelay[11] >= 20) {
					Globals.Tags.F2_FS_L.Value = 1;
				} else {
					arrayDelay[11]++;
				}
			} else {
				arrayDelay[11] = 0;
				Globals.Tags.F2_FS_L.Value = 0;
			}
			
			//温度高
			if ((Globals.Tags.dis_tem1_f2.Value >= Globals.Tags.F1_T_H.Value)) {
				if (arrayDelay[12] >= 20) {
					Globals.Tags.F2_TS_H.Value = 1;
				} else {
					arrayDelay[12]++;
				}
			} else {
				arrayDelay[12] = 0;
				Globals.Tags.F2_TS_H.Value = 0;
			}
			
			//ABC输出电流高
			if ((Globals.Tags.dis_iaf_f2.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[13] >= 1) {
					Globals.Tags.F2_CS_A_H.Value = 1;
				} else {
					arrayDelay[13]++;
				}
			} else {
				arrayDelay[13] = 0;
				Globals.Tags.F2_CS_A_H.Value = 0;
			}
			
			if ((Globals.Tags.dis_ibf_f2.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[14] >= 1) {
					Globals.Tags.F2_CS_B_H.Value = 1;
				} else {
					arrayDelay[14]++;
				}
			} else {
				arrayDelay[14] = 0;
				Globals.Tags.F2_CS_B_H.Value = 0;
			}
			
			if ((Globals.Tags.dis_icf_f2.Value >= Globals.Tags.F1_C_H.Value)) {
				if (arrayDelay[15] >= 1) {
					Globals.Tags.F2_CS_C_H.Value = 1;
				} else {
					arrayDelay[15]++;
				}
			} else {
				arrayDelay[15] = 0;
				Globals.Tags.F2_CS_C_H.Value = 0;
			}
			
			//三相不平衡
			float avg1 = (Globals.Tags.dis_ial.Value + Globals.Tags.dis_ibl.Value + Globals.Tags.dis_icl.Value) / 3.0;
			
			Globals.Tags.dev_dis_ial.Value = Math.Abs(Globals.Tags.dis_ial.Value - avg1);
			Globals.Tags.dev_dis_ibl.Value = Math.Abs(Globals.Tags.dis_ibl.Value - avg1);
			Globals.Tags.dev_dis_icl.Value = Math.Abs(Globals.Tags.dis_icl.Value - avg1);
			
			if ((Globals.Tags.dev_dis_ial.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl.Value >= Globals.Tags.F1_D_H.Value)) {
				if (arrayDelay[16] >= 20) {
					Globals.Tags.F1_DS_H.Value = 1;
				} else {
					arrayDelay[16]++;
				}
			} else {
				arrayDelay[16] = 0;
				Globals.Tags.F1_DS_H.Value = 0;
			}

			/*if (Globals.Tags.dev_dis_ial.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl.Value >= Globals.Tags.F1_D_H.Value) {
				Globals.Tags.F1_DS_H.Value = 1;
			} else {
				Globals.Tags.F1_DS_H.Value = 0;
			}*/

			float avg2 = (Globals.Tags.dis_ial_f2.Value + Globals.Tags.dis_ibl_f2.Value + Globals.Tags.dis_icl_f2.Value) / 3.0;
			
			Globals.Tags.dev_dis_ial_f2.Value = Math.Abs(Globals.Tags.dis_ial_f2.Value - avg2);
			Globals.Tags.dev_dis_ibl_f2.Value = Math.Abs(Globals.Tags.dis_ibl_f2.Value - avg2);
			Globals.Tags.dev_dis_icl_f2.Value = Math.Abs(Globals.Tags.dis_icl_f2.Value - avg2);
			
			if ((Globals.Tags.dev_dis_ial_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl_f2.Value >= Globals.Tags.F1_D_H.Value)) {
				if (arrayDelay[17] >= 20) {
					Globals.Tags.F2_DS_H.Value = 1;
				} else {
					arrayDelay[17]++;
				}
			} else {
				arrayDelay[17] = 0;
				Globals.Tags.F2_DS_H.Value = 0;
			}

			/*if (Globals.Tags.dev_dis_ial_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_ibl_f2.Value >= Globals.Tags.F1_D_H.Value || Globals.Tags.dev_dis_icl_f2.Value >= Globals.Tags.F1_D_H.Value) {
				Globals.Tags.F2_DS_H.Value = 1;
			} else {
				Globals.Tags.F2_DS_H.Value = 0;
			}*/
			

			/*模块2*/
			//ABC电压高
			/*Globals.Tags.F2_VS_A_H.Value = (Globals.Tags.dis_usa_173_f2.Value>= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usb_173_f2.Value >= Globals.Tags.F1_V_H.Value || Globals.Tags.dis_usc_173_f2.Value >= Globals.Tags.F1_V_H.Value)?1:0;
			
			//ABC电压低
			Globals.Tags.F1_VS_A_L.Value = (Globals.Tags.dis_usa_173_f2.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usb_173_f2.Value <= Globals.Tags.F1_V_L.Value || Globals.Tags.dis_usc_173_f2.Value <= Globals.Tags.F1_V_L.Value)?1:0;
			
			
			//频率高低
			Globals.Tags.F2_FS_H.Value = (Globals.Tags.freqvalue_measure_f2.Value.Double  >= Globals.Tags.F1_F_H.Value.Double)?1:0;
			Globals.Tags.F2_FS_L.Value = (Globals.Tags.freqvalue_measure_f2.Value.Double  <= Globals.Tags.F1_F_L.Value.Double)?1:0;
			
			//温度高
			Globals.Tags.F2_TS_H.Value = (Globals.Tags.dis_tem1_f2.Value >= Globals.Tags.F1_T_H.Value)?1:0;
			
			//ABC输出电流高
			Globals.Tags.F2_CS_A_H.Value = (Globals.Tags.dis_iaf_f2.Value >= Globals.Tags.F1_C_H.Value)?1:0;
			Globals.Tags.F2_CS_B_H.Value = (Globals.Tags.dis_ibf_f2.Value >= Globals.Tags.F1_C_H.Value)?1:0;
			Globals.Tags.F2_CS_C_H.Value = (Globals.Tags.dis_icf_f2.Value >= Globals.Tags.F1_C_H.Value)?1:0;*/
			
		}
		
		//综合报警输出，常闭
		void commonAlarm(object sender, EventArgs e) {
			bool hasAnyAlarmsm = (Globals.Tags.F1_VS_A_H.Value==1) || (Globals.Tags.F1_VS_A_L.Value==1) || (Globals.Tags.F1_FS_H.Value==1)
				|| (Globals.Tags.F1_FS_L.Value==1) || (Globals.Tags.F1_TS_H.Value==1) || (Globals.Tags.F1_CS_A_H.Value==1)
				|| (Globals.Tags.F1_CS_B_H.Value==1) || (Globals.Tags.F1_CS_C_H.Value==1) || (Globals.Tags.err1_11.Value==1)
				|| (Globals.Tags.err1_12.Value==1) || (Globals.Tags.err1_13.Value==1) || (Globals.Tags.F1_DS_H.Value==1)
				|| (Globals.Tags.F2_VS_A_H.Value==1) || (Globals.Tags.F2_VS_A_L.Value==1) || (Globals.Tags.F2_FS_H.Value==1)
				|| (Globals.Tags.F2_FS_L.Value==1) || (Globals.Tags.F2_TS_H.Value==1) || (Globals.Tags.F2_CS_A_H.Value==1)
				|| (Globals.Tags.F2_CS_B_H.Value==1) || (Globals.Tags.F2_CS_C_H.Value==1) || (Globals.Tags.err1_11_f2.Value==1)
				|| (Globals.Tags.err1_12_f2.Value==1) || (Globals.Tags.err1_13_f2.Value==1) || (Globals.Tags.F2_DS_H.Value==1);
			
			if(hasAnyAlarmsm) 
			{
				Globals.Tags.DO_M.Value |=  1<<2 ;
			}
			else
			{
				Globals.Tags.DO_M.Value &= ((1 << 2) ^ 0xff);
			}
		}
    }
}
