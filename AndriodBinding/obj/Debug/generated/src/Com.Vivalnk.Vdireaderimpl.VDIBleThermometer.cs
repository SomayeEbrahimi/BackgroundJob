using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleThermometer", DoNotGenerateAcw=true)]
	public partial class VDIBleThermometer : global::Java.Lang.Object, global::Com.Vivalnk.Vdireader.IVDICommonBleReader {


		static IntPtr c_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='c']"
		[Register ("c")]
		protected global::System.Collections.IList C {
			get {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, c_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (c_jfieldId == IntPtr.Zero)
					c_jfieldId = JNIEnv.GetFieldID (class_ref, "c", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, c_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr d_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='d']"
		[Register ("d")]
		public static int D {
			get {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "I");
				return JNIEnv.GetStaticIntField (class_ref, d_jfieldId);
			}
			set {
				if (d_jfieldId == IntPtr.Zero)
					d_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "d", "I");
				try {
					JNIEnv.SetStaticField (class_ref, d_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr e_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='e']"
		[Register ("e")]
		protected bool E {
			get {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, e_jfieldId);
			}
			set {
				if (e_jfieldId == IntPtr.Zero)
					e_jfieldId = JNIEnv.GetFieldID (class_ref, "e", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, e_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr f_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='f']"
		[Register ("f")]
		protected bool F {
			get {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, f_jfieldId);
			}
			set {
				if (f_jfieldId == IntPtr.Zero)
					f_jfieldId = JNIEnv.GetFieldID (class_ref, "f", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, f_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='g']"
		[Register ("g")]
		protected bool G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr h_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='h']"
		[Register ("h")]
		protected bool H {
			get {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, h_jfieldId);
			}
			set {
				if (h_jfieldId == IntPtr.Zero)
					h_jfieldId = JNIEnv.GetFieldID (class_ref, "h", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, h_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/vivalnk/vdireaderimpl/VDIBleThermometer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VDIBleThermometer); }
		}

		protected VDIBleThermometer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/constructor[@name='VDIBleThermometer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VDIBleThermometer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (VDIBleThermometer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getLostThreshold;
#pragma warning disable 0169
		static Delegate GetGetLostThresholdHandler ()
		{
			if (cb_getLostThreshold == null)
				cb_getLostThreshold = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLostThreshold);
			return cb_getLostThreshold;
		}

		static int n_GetLostThreshold (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LostThreshold;
		}
#pragma warning restore 0169

		static Delegate cb_setLostThreshold_I;
#pragma warning disable 0169
		static Delegate GetSetLostThreshold_IHandler ()
		{
			if (cb_setLostThreshold_I == null)
				cb_setLostThreshold_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLostThreshold_I);
			return cb_setLostThreshold_I;
		}

		static void n_SetLostThreshold_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LostThreshold = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLostThreshold;
		static IntPtr id_setLostThreshold_I;
		public virtual unsafe int LostThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getLostThreshold' and count(parameter)=0]"
			[Register ("getLostThreshold", "()I", "GetGetLostThresholdHandler")]
			get {
				if (id_getLostThreshold == IntPtr.Zero)
					id_getLostThreshold = JNIEnv.GetMethodID (class_ref, "getLostThreshold", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLostThreshold);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLostThreshold", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setLostThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLostThreshold", "(I)V", "GetSetLostThreshold_IHandler")]
			set {
				if (id_setLostThreshold_I == IntPtr.Zero)
					id_setLostThreshold_I = JNIEnv.GetMethodID (class_ref, "setLostThreshold", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLostThreshold_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLostThreshold", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPDListLength;
#pragma warning disable 0169
		static Delegate GetGetPDListLengthHandler ()
		{
			if (cb_getPDListLength == null)
				cb_getPDListLength = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPDListLength);
			return cb_getPDListLength;
		}

		static int n_GetPDListLength (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PDListLength;
		}
#pragma warning restore 0169

		static IntPtr id_getPDListLength;
		public virtual unsafe int PDListLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getPDListLength' and count(parameter)=0]"
			[Register ("getPDListLength", "()I", "GetGetPDListLengthHandler")]
			get {
				if (id_getPDListLength == IntPtr.Zero)
					id_getPDListLength = JNIEnv.GetMethodID (class_ref, "getPDListLength", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPDListLength);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPDListLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPairingRssi;
#pragma warning disable 0169
		static Delegate GetGetPairingRssiHandler ()
		{
			if (cb_getPairingRssi == null)
				cb_getPairingRssi = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPairingRssi);
			return cb_getPairingRssi;
		}

		static int n_GetPairingRssi (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PairingRssi;
		}
#pragma warning restore 0169

		static Delegate cb_setPairingRssi_I;
#pragma warning disable 0169
		static Delegate GetSetPairingRssi_IHandler ()
		{
			if (cb_setPairingRssi_I == null)
				cb_setPairingRssi_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPairingRssi_I);
			return cb_setPairingRssi_I;
		}

		static void n_SetPairingRssi_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PairingRssi = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPairingRssi;
		static IntPtr id_setPairingRssi_I;
		public virtual unsafe int PairingRssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getPairingRssi' and count(parameter)=0]"
			[Register ("getPairingRssi", "()I", "GetGetPairingRssiHandler")]
			get {
				if (id_getPairingRssi == IntPtr.Zero)
					id_getPairingRssi = JNIEnv.GetMethodID (class_ref, "getPairingRssi", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPairingRssi);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPairingRssi", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setPairingRssi' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPairingRssi", "(I)V", "GetSetPairingRssi_IHandler")]
			set {
				if (id_setPairingRssi_I == IntPtr.Zero)
					id_setPairingRssi_I = JNIEnv.GetMethodID (class_ref, "setPairingRssi", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPairingRssi_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPairingRssi", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_A);
			return cb_a;
		}

		static bool n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		protected virtual unsafe bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_a);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Z"));
			} finally {
			}
		}

		static Delegate cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
#pragma warning disable 0169
		static Delegate GetA_Landroid_bluetooth_BluetoothDevice_IarrayBHandler ()
		{
			if (cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB == null)
				cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_A_Landroid_bluetooth_BluetoothDevice_IarrayB);
			return cb_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
		}

		static void n_A_Landroid_bluetooth_BluetoothDevice_IarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Bluetooth.BluetoothDevice> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.A (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_bluetooth_BluetoothDevice_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothDevice;I[B)V", "GetA_Landroid_bluetooth_BluetoothDevice_IarrayBHandler")]
		protected virtual unsafe void A (global::Android.Bluetooth.BluetoothDevice p0, int p1, byte[] p2)
		{
			if (id_a_Landroid_bluetooth_BluetoothDevice_IarrayB == IntPtr.Zero)
				id_a_Landroid_bluetooth_BluetoothDevice_IarrayB = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/bluetooth/BluetoothDevice;I[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_bluetooth_BluetoothDevice_IarrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/bluetooth/BluetoothDevice;I[B)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_a_arrayB;
#pragma warning disable 0169
		static Delegate GetA_arrayBHandler ()
		{
			if (cb_a_arrayB == null)
				cb_a_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_A_arrayB);
			return cb_a_arrayB;
		}

		static IntPtr n_A_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.A (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)Ljava/lang/String;", "GetA_arrayBHandler")]
		public virtual unsafe string A (byte[] p0)
		{
			if (id_a_arrayB == IntPtr.Zero)
				id_a_arrayB = JNIEnv.GetMethodID (class_ref, "a", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addPDList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPDList_Ljava_lang_String_Handler ()
		{
			if (cb_addPDList_Ljava_lang_String_ == null)
				cb_addPDList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddPDList_Ljava_lang_String_);
			return cb_addPDList_Ljava_lang_String_;
		}

		static bool n_AddPDList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPDList (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPDList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='addPDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddPDList (string p0)
		{
			if (id_addPDList_Ljava_lang_String_ == IntPtr.Zero)
				id_addPDList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPDList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addPDList_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPDList", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addPDList_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPDList_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addPDList_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addPDList_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_AddPDList_Ljava_lang_String_Ljava_lang_String_);
			return cb_addPDList_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_AddPDList_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPDList (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addPDList_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='addPDList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddPDList (string p0, string p1)
		{
			if (id_addPDList_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addPDList_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addPDList_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_B);
			return cb_b;
		}

		static void n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B ();
		}
#pragma warning restore 0169

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected virtual unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_b);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkBle;
#pragma warning disable 0169
		static Delegate GetCheckBleHandler ()
		{
			if (cb_checkBle == null)
				cb_checkBle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_CheckBle);
			return cb_checkBle;
		}

		static IntPtr n_CheckBle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckBle ());
		}
#pragma warning restore 0169

		static IntPtr id_checkBle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='checkBle' and count(parameter)=0]"
		[Register ("checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "GetCheckBleHandler")]
		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE CheckBle ()
		{
			if (id_checkBle == IntPtr.Zero)
				id_checkBle = JNIEnv.GetMethodID (class_ref, "checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkBle), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_iteratePDList;
#pragma warning disable 0169
		static Delegate GetIteratePDListHandler ()
		{
			if (cb_iteratePDList == null)
				cb_iteratePDList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IteratePDList);
			return cb_iteratePDList;
		}

		static IntPtr n_IteratePDList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.IteratePDList ());
		}
#pragma warning restore 0169

		static IntPtr id_iteratePDList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='iteratePDList' and count(parameter)=0]"
		[Register ("iteratePDList", "()Ljava/util/ArrayList;", "GetIteratePDListHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> IteratePDList ()
		{
			if (id_iteratePDList == IntPtr.Zero)
				id_iteratePDList = JNIEnv.GetMethodID (class_ref, "iteratePDList", "()Ljava/util/ArrayList;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iteratePDList), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iteratePDList", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_purgePDList;
#pragma warning disable 0169
		static Delegate GetPurgePDListHandler ()
		{
			if (cb_purgePDList == null)
				cb_purgePDList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PurgePDList);
			return cb_purgePDList;
		}

		static void n_PurgePDList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PurgePDList ();
		}
#pragma warning restore 0169

		static IntPtr id_purgePDList;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='purgePDList' and count(parameter)=0]"
		[Register ("purgePDList", "()V", "GetPurgePDListHandler")]
		public virtual unsafe void PurgePDList ()
		{
			if (id_purgePDList == IntPtr.Zero)
				id_purgePDList = JNIEnv.GetMethodID (class_ref, "purgePDList", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_purgePDList);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "purgePDList", "()V"));
			} finally {
			}
		}

		static Delegate cb_removePDList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemovePDList_Ljava_lang_String_Handler ()
		{
			if (cb_removePDList_Ljava_lang_String_ == null)
				cb_removePDList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemovePDList_Ljava_lang_String_);
			return cb_removePDList_Ljava_lang_String_;
		}

		static bool n_RemovePDList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemovePDList (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removePDList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='removePDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removePDList", "(Ljava/lang/String;)Z", "GetRemovePDList_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemovePDList (string p0)
		{
			if (id_removePDList_Ljava_lang_String_ == IntPtr.Zero)
				id_removePDList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removePDList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removePDList_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePDList", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_Handler ()
		{
			if (cb_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ == null)
				cb_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_);
			return cb_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_;
		}

		static void n_SetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Vdireader.IVDICommonBleListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDICommonBleListener']]"
		[Register ("setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V", "GetSetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Vivalnk.Vdireader.IVDICommonBleListener p0)
		{
			if (id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ == IntPtr.Zero)
				id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startDeviceDiscovery;
#pragma warning disable 0169
		static Delegate GetStartDeviceDiscoveryHandler ()
		{
			if (cb_startDeviceDiscovery == null)
				cb_startDeviceDiscovery = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartDeviceDiscovery);
			return cb_startDeviceDiscovery;
		}

		static void n_StartDeviceDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDeviceDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_startDeviceDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='startDeviceDiscovery' and count(parameter)=0]"
		[Register ("startDeviceDiscovery", "()V", "GetStartDeviceDiscoveryHandler")]
		public virtual unsafe void StartDeviceDiscovery ()
		{
			if (id_startDeviceDiscovery == IntPtr.Zero)
				id_startDeviceDiscovery = JNIEnv.GetMethodID (class_ref, "startDeviceDiscovery", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDeviceDiscovery);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startDeviceDiscovery", "()V"));
			} finally {
			}
		}

		static Delegate cb_startTemperatureUpdate;
#pragma warning disable 0169
		static Delegate GetStartTemperatureUpdateHandler ()
		{
			if (cb_startTemperatureUpdate == null)
				cb_startTemperatureUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartTemperatureUpdate);
			return cb_startTemperatureUpdate;
		}

		static void n_StartTemperatureUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTemperatureUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_startTemperatureUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='startTemperatureUpdate' and count(parameter)=0]"
		[Register ("startTemperatureUpdate", "()V", "GetStartTemperatureUpdateHandler")]
		public virtual unsafe void StartTemperatureUpdate ()
		{
			if (id_startTemperatureUpdate == IntPtr.Zero)
				id_startTemperatureUpdate = JNIEnv.GetMethodID (class_ref, "startTemperatureUpdate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startTemperatureUpdate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startTemperatureUpdate", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopDeviceDiscovery;
#pragma warning disable 0169
		static Delegate GetStopDeviceDiscoveryHandler ()
		{
			if (cb_stopDeviceDiscovery == null)
				cb_stopDeviceDiscovery = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopDeviceDiscovery);
			return cb_stopDeviceDiscovery;
		}

		static void n_StopDeviceDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDeviceDiscovery ();
		}
#pragma warning restore 0169

		static IntPtr id_stopDeviceDiscovery;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='stopDeviceDiscovery' and count(parameter)=0]"
		[Register ("stopDeviceDiscovery", "()V", "GetStopDeviceDiscoveryHandler")]
		public virtual unsafe void StopDeviceDiscovery ()
		{
			if (id_stopDeviceDiscovery == IntPtr.Zero)
				id_stopDeviceDiscovery = JNIEnv.GetMethodID (class_ref, "stopDeviceDiscovery", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopDeviceDiscovery);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopDeviceDiscovery", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopTemperatureUpdate;
#pragma warning disable 0169
		static Delegate GetStopTemperatureUpdateHandler ()
		{
			if (cb_stopTemperatureUpdate == null)
				cb_stopTemperatureUpdate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopTemperatureUpdate);
			return cb_stopTemperatureUpdate;
		}

		static void n_StopTemperatureUpdate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTemperatureUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_stopTemperatureUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='stopTemperatureUpdate' and count(parameter)=0]"
		[Register ("stopTemperatureUpdate", "()V", "GetStopTemperatureUpdateHandler")]
		public virtual unsafe void StopTemperatureUpdate ()
		{
			if (id_stopTemperatureUpdate == IntPtr.Zero)
				id_stopTemperatureUpdate = JNIEnv.GetMethodID (class_ref, "stopTemperatureUpdate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopTemperatureUpdate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopTemperatureUpdate", "()V"));
			} finally {
			}
		}

		static Delegate cb_suspend;
#pragma warning disable 0169
		static Delegate GetSuspendHandler ()
		{
			if (cb_suspend == null)
				cb_suspend = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Suspend);
			return cb_suspend;
		}

		static void n_Suspend (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireaderimpl.VDIBleThermometer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Suspend ();
		}
#pragma warning restore 0169

		static IntPtr id_suspend;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='suspend' and count(parameter)=0]"
		[Register ("suspend", "()V", "GetSuspendHandler")]
		public virtual unsafe void Suspend ()
		{
			if (id_suspend == IntPtr.Zero)
				id_suspend = JNIEnv.GetMethodID (class_ref, "suspend", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_suspend);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "suspend", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Vivalnk.Vdireader.IVDICommonBleListener"

		global::Com.Vivalnk.Vdireader.IVDICommonBleListenerImplementor __CreateIVDICommonBleListenerImplementor ()
		{
			return new global::Com.Vivalnk.Vdireader.IVDICommonBleListenerImplementor (this);
		}
#endregion
	}
}
