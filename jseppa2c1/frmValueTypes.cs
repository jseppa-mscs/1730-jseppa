﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa2c1
{
    public partial class frmValueTypes : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;
        public frmValueTypes()
        {
            InitializeComponent();
        }

        private void setMinButton_Click(object sender, EventArgs e)
        {
            byte1 = Byte.MinValue;          byte1textbox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue;        sbyte1textbox.Text = sbyte1.ToString();
            short1 = Int16.MinValue;        short1textbox.Text = short1.ToString();
            ushort1 = UInt16.MinValue;      ushort1textbox.Text = ushort1.ToString();
            int1 = Int32.MinValue;          int1textbox.Text = int1.ToString();
            uint1 = UInt32.MinValue;        uint1textbox.Text = uint1.ToString();
            long1 = Int64.MinValue;         long1textbox.Text = long1.ToString();
            ulong1 = UInt64.MinValue;       ulong1textbox.Text = ulong1.ToString();
            float1 = Single.MinValue;       float1textbox.Text = float1.ToString();
            double1 = Double.MinValue;      double1textbox.Text = double1.ToString();
            decimal1 = Decimal.MinValue;    decimal1textbox.Text = decimal1.ToString();
        }
        private void setMaxButton_Click(object sender, EventArgs e)
        {
            byte2 = Byte.MaxValue; byte2textbox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; sbyte2textbox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2textbox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2textbox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2textbox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2textbox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2textbox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2textbox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2textbox.Text = float2.ToString();
            double2 = Double.MaxValue; double2textbox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; decimal2textbox.Text = decimal2.ToString();
        }
        private void input2textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2textBox.Text);
                byte2textbox.Text = byte2.ToString();
            }
            catch (Exception) { byte2textbox.Text = "error"; }
            try
            {
                sbyte2 = Convert.ToSByte(input2textBox.Text);
                sbyte2textbox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2textbox.Text = "error"; }
            try
            {
                short2 = Convert.ToInt16(input2textBox.Text);
                short2textbox.Text = short2.ToString();
            }
            catch (Exception) { short2textbox.Text = "error"; }
            try
            {
                ushort2 = Convert.ToUInt16(input2textBox.Text);
                ushort2textbox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2textbox.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(input2textBox.Text);
                int2textbox.Text = int2.ToString();
            }
            catch (Exception) { int2textbox.Text = "error"; }
            try
            {
                uint2 = Convert.ToUInt32(input2textBox.Text);
                uint2textbox.Text = uint2.ToString();
            }
            catch (Exception) { uint2textbox.Text = "error"; }
            try
            {
                long2 = Convert.ToInt64(input2textBox.Text);
                long2textbox.Text = long2.ToString();
            }
            catch (Exception) { long2textbox.Text = "error"; }
            try
            {
                ulong2 = Convert.ToUInt64(input2textBox.Text);
                ulong2textbox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2textbox.Text = "error"; }
            try
            {
                float2 = Convert.ToSingle(input2textBox.Text);
                float2textbox.Text = float2.ToString();
            }
            catch (Exception) { float2textbox.Text = "error"; }
            try
            {
                double2 = Convert.ToDouble(input2textBox.Text);
                double2textbox.Text = double2.ToString();
            }
            catch (Exception) { double2textbox.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(input2textBox.Text);
                decimal2textbox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2textbox.Text = "error"; }
        }
        private void input1textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(input1textBox.Text);
                byte1textbox.Text = byte1.ToString();
            } 
            catch (Exception) { byte1textbox.Text = "error"; }
            try
            {
                sbyte1 = Convert.ToSByte(input1textBox.Text);
                sbyte1textbox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyte1textbox.Text = "error"; }
            try
            {
                short1 = Convert.ToInt16(input1textBox.Text);
                short1textbox.Text = short1.ToString();
            }
            catch (Exception) { short1textbox.Text = "error"; }
            try
            {
                ushort1 = Convert.ToUInt16(input1textBox.Text);
                ushort1textbox.Text = ushort1.ToString();
            }
            catch (Exception) { ushort1textbox.Text = "error"; }
            try
            {
                int1 = Convert.ToInt32(input1textBox.Text);
                int1textbox.Text = int1.ToString();
            }
            catch (Exception) { int1textbox.Text = "error"; }
            try
            {
                uint1 = Convert.ToUInt32(input1textBox.Text);
                uint1textbox.Text = uint1.ToString();
            }
            catch (Exception) { uint1textbox.Text = "error"; }
            try
            {
                long1 = Convert.ToInt64(input1textBox.Text);
                long1textbox.Text = long1.ToString();
            }
            catch (Exception) { long1textbox.Text = "error"; }
            try
            {
                ulong1 = Convert.ToUInt64(input1textBox.Text);
                ulong1textbox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1textbox.Text = "error"; }
            try
            {
                float1 = Convert.ToSingle(input1textBox.Text);
                float1textbox.Text = float1.ToString();
            }
            catch (Exception) { float1textbox.Text = "error"; }
            try
            {
                double1 = Convert.ToDouble(input1textBox.Text);
                double1textbox.Text = double1.ToString();
            }
            catch (Exception) { double1textbox.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(input1textBox.Text);
                decimal1textbox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1textbox.Text = "error"; }


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                byte3textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3textbox.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 + this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; int3 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; uint3 = 0; }
            try
            {
                this.long3 = checked(this.long1 + this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; long3 = 0; }
            try
            {
                this.ulong3 = checked(this.ulong1 + this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; ulong3 = 0; }
            try
            {
                this.float3 = checked(this.float1 + this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; float3 = 0.0f; }
            try
            {
                this.double3 = checked(this.double1 + this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; double3 = 0.0; }
            try
            {
                this.decimal3 = checked(this.decimal1 + this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; decimal3 = 0m; }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                byte3textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3textbox.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 * this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; int3 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 * this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; uint3 = 0; }
            try
            {
                this.long3 = checked(this.long1 * this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; long3 = 0; }
            try
            {
                this.ulong3 = checked(this.ulong1 * this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; ulong3 = 0; }
            try
            {
                this.float3 = checked(this.float1 * this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; float3 = 0.0f; }
            try
            {
                this.double3 = checked(this.double1 * this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; double3 = 0.0; }
            try
            {
                this.decimal3 = checked(this.decimal1 * this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; decimal3 = 0m; }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                byte3textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3textbox.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 / this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; int3 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; uint3 = 0; }
            try
            {
                this.long3 = checked(this.long1 / this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; long3 = 0; }
            try
            {
                this.ulong3 = checked(this.ulong1 / this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; ulong3 = 0; }
            try
            {
                this.float3 = checked(this.float1 / this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; float3 = 0.0f; }
            try
            {
                this.double3 = checked(this.double1 / this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; double3 = 0.0; }
            try
            {
                this.decimal3 = checked(this.decimal1 / this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; decimal3 = 0m; }
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                byte3textbox.Text = byte3.ToString();
            }
            catch (Exception) { byte3textbox.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                sbyte3textbox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3textbox.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                short3textbox.Text = short3.ToString();
            }
            catch (Exception) { short3textbox.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                ushort3textbox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3textbox.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 - this.int2);
                int3textbox.Text = int3.ToString();
            }
            catch (Exception) { int3textbox.Text = "error"; int3 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                uint3textbox.Text = uint3.ToString();
            }
            catch (Exception) { uint3textbox.Text = "error"; uint3 = 0; }
            try
            {
                this.long3 = checked(this.long1 - this.long2);
                long3textbox.Text = long3.ToString();
            }
            catch (Exception) { long3textbox.Text = "error"; long3 = 0; }
            try
            {
                this.ulong3 = checked(this.ulong1 - this.ulong2);
                ulong3textbox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3textbox.Text = "error"; ulong3 = 0; }
            try
            {
                this.float3 = checked(this.float1 - this.float2);
                float3textbox.Text = float3.ToString();
            }
            catch (Exception) { float3textbox.Text = "error"; float3 = 0.0f; }
            try
            {
                this.double3 = checked(this.double1 - this.double2);
                double3textbox.Text = double3.ToString();
            }
            catch (Exception) { double3textbox.Text = "error"; double3 = 0.0; }
            try
            {
                this.decimal3 = checked(this.decimal1 - this.decimal2);
                decimal3textbox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3textbox.Text = "error"; decimal3 = 0m; }
        }
    }
}
