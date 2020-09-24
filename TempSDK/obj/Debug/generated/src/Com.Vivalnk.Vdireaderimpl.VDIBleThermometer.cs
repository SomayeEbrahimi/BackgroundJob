using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdireaderimpl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']"
	[global::Android.Runtime.Register ("com/vivalnk/vdireaderimpl/VDIBleThermometer", DoNotGenerateAcw=true)]
	public partial class VDIBleThermometer : global::Java.Lang.Object, global::Com.Vivalnk.Vdireader.IVDICommonBleReader {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='c']"
		[Register ("c")]
		protected global::System.Collections.IList C {
			get {
				const string __id = "c.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='d']"
		[Register ("d")]
		public static int D {
			get {
				const string __id = "d.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "d.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='e']"
		[Register ("e")]
		protected bool E {
			get {
				const string __id = "e.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "e.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='f']"
		[Register ("f")]
		protected bool F {
			get {
				const string __id = "f.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "f.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='g']"
		[Register ("g")]
		protected bool G {
			get {
				const string __id = "g.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "g.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/field[@name='h']"
		[Register ("h")]
		protected bool H {
			get {
				const string __id = "h.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "h.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireaderimpl/VDIBleThermometer", typeof (VDIBleThermometer));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected VDIBleThermometer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/constructor[@name='VDIBleThermometer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VDIBleThermometer (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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

		public virtual unsafe int LostThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getLostThreshold' and count(parameter)=0]"
			[Register ("getLostThreshold", "()I", "GetGetLostThresholdHandler")]
			get {
				const string __id = "getLostThreshold.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setLostThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLostThreshold", "(I)V", "GetSetLostThreshold_IHandler")]
			set {
				const string __id = "setLostThreshold.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		public virtual unsafe int PDListLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getPDListLength' and count(parameter)=0]"
			[Register ("getPDListLength", "()I", "GetGetPDListLengthHandler")]
			get {
				const string __id = "getPDListLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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

		public virtual unsafe int PairingRssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='getPairingRssi' and count(parameter)=0]"
			[Register ("getPairingRssi", "()I", "GetGetPairingRssiHandler")]
			get {
				const string __id = "getPairingRssi.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setPairingRssi' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPairingRssi", "(I)V", "GetSetPairingRssi_IHandler")]
			set {
				const string __id = "setPairingRssi.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "GetAHandler")]
		protected virtual unsafe bool A ()
		{
			const string __id = "a.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.bluetooth.BluetoothDevice'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("a", "(Landroid/bluetooth/BluetoothDevice;I[B)V", "GetA_Landroid_bluetooth_BluetoothDevice_IarrayBHandler")]
		protected virtual unsafe void A (global::Android.Bluetooth.BluetoothDevice p0, int p1, byte[] p2)
		{
			const string __id = "a.(Landroid/bluetooth/BluetoothDevice;I[B)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("a", "([B)Ljava/lang/String;", "GetA_arrayBHandler")]
		public virtual unsafe string A (byte[] p0)
		{
			const string __id = "a.([B)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='addPDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddPDList (string p0)
		{
			const string __id = "addPDList.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='addPDList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool AddPDList (string p0, string p1)
		{
			const string __id = "addPDList.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "GetBHandler")]
		protected virtual unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='checkBle' and count(parameter)=0]"
		[Register ("checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "GetCheckBleHandler")]
		public virtual unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE CheckBle ()
		{
			const string __id = "checkBle.()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='iteratePDList' and count(parameter)=0]"
		[Register ("iteratePDList", "()Ljava/util/ArrayList;", "GetIteratePDListHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> IteratePDList ()
		{
			const string __id = "iteratePDList.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='purgePDList' and count(parameter)=0]"
		[Register ("purgePDList", "()V", "GetPurgePDListHandler")]
		public virtual unsafe void PurgePDList ()
		{
			const string __id = "purgePDList.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='removePDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removePDList", "(Ljava/lang/String;)Z", "GetRemovePDList_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemovePDList (string p0)
		{
			const string __id = "removePDList.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDICommonBleListener']]"
		[Register ("setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V", "GetSetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Vivalnk.Vdireader.IVDICommonBleListener p0)
		{
			const string __id = "setListener.(Lcom/vivalnk/vdireader/VDICommonBleListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='startDeviceDiscovery' and count(parameter)=0]"
		[Register ("startDeviceDiscovery", "()V", "GetStartDeviceDiscoveryHandler")]
		public virtual unsafe void StartDeviceDiscovery ()
		{
			const string __id = "startDeviceDiscovery.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='startTemperatureUpdate' and count(parameter)=0]"
		[Register ("startTemperatureUpdate", "()V", "GetStartTemperatureUpdateHandler")]
		public virtual unsafe void StartTemperatureUpdate ()
		{
			const string __id = "startTemperatureUpdate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='stopDeviceDiscovery' and count(parameter)=0]"
		[Register ("stopDeviceDiscovery", "()V", "GetStopDeviceDiscoveryHandler")]
		public virtual unsafe void StopDeviceDiscovery ()
		{
			const string __id = "stopDeviceDiscovery.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='stopTemperatureUpdate' and count(parameter)=0]"
		[Register ("stopTemperatureUpdate", "()V", "GetStopTemperatureUpdateHandler")]
		public virtual unsafe void StopTemperatureUpdate ()
		{
			const string __id = "stopTemperatureUpdate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireaderimpl']/class[@name='VDIBleThermometer']/method[@name='suspend' and count(parameter)=0]"
		[Register ("suspend", "()V", "GetSuspendHandler")]
		public virtual unsafe void Suspend ()
		{
			const string __id = "suspend.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
