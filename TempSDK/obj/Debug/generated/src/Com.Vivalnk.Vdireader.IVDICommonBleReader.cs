using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Vdireader {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']"
	[Register ("com/vivalnk/vdireader/VDICommonBleReader", "", "Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker")]
	public partial interface IVDICommonBleReader : IJavaObject, IJavaPeerable {

		int LostThreshold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='getLostThreshold' and count(parameter)=0]"
			[Register ("getLostThreshold", "()I", "GetGetLostThresholdHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='setLostThreshold' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLostThreshold", "(I)V", "GetSetLostThreshold_IHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")] set;
		}

		int PDListLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='getPDListLength' and count(parameter)=0]"
			[Register ("getPDListLength", "()I", "GetGetPDListLengthHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")] get;
		}

		int PairingRssi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='getPairingRssi' and count(parameter)=0]"
			[Register ("getPairingRssi", "()I", "GetGetPairingRssiHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='setPairingRssi' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPairingRssi", "(I)V", "GetSetPairingRssi_IHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='addPDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Handler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		bool AddPDList (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='addPDList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetAddPDList_Ljava_lang_String_Ljava_lang_String_Handler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		bool AddPDList (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='checkBle' and count(parameter)=0]"
		[Register ("checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;", "GetCheckBleHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE CheckBle ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='iteratePDList' and count(parameter)=0]"
		[Register ("iteratePDList", "()Ljava/util/ArrayList;", "GetIteratePDListHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		global::System.Collections.Generic.IList<string> IteratePDList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='purgePDList' and count(parameter)=0]"
		[Register ("purgePDList", "()V", "GetPurgePDListHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void PurgePDList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='removePDList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removePDList", "(Ljava/lang/String;)Z", "GetRemovePDList_Ljava_lang_String_Handler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		bool RemovePDList (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void Resume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.vivalnk.vdireader.VDICommonBleListener']]"
		[Register ("setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V", "GetSetListener_Lcom_vivalnk_vdireader_VDICommonBleListener_Handler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void SetListener (global::Com.Vivalnk.Vdireader.IVDICommonBleListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='startDeviceDiscovery' and count(parameter)=0]"
		[Register ("startDeviceDiscovery", "()V", "GetStartDeviceDiscoveryHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void StartDeviceDiscovery ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='startTemperatureUpdate' and count(parameter)=0]"
		[Register ("startTemperatureUpdate", "()V", "GetStartTemperatureUpdateHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void StartTemperatureUpdate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='stopDeviceDiscovery' and count(parameter)=0]"
		[Register ("stopDeviceDiscovery", "()V", "GetStopDeviceDiscoveryHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void StopDeviceDiscovery ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='stopTemperatureUpdate' and count(parameter)=0]"
		[Register ("stopTemperatureUpdate", "()V", "GetStopTemperatureUpdateHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void StopTemperatureUpdate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.vdireader']/interface[@name='VDICommonBleReader']/method[@name='suspend' and count(parameter)=0]"
		[Register ("suspend", "()V", "GetSuspendHandler:Com.Vivalnk.Vdireader.IVDICommonBleReaderInvoker, TempSDK")]
		void Suspend ();

	}

	[global::Android.Runtime.Register ("com/vivalnk/vdireader/VDICommonBleReader", DoNotGenerateAcw=true)]
	internal partial class IVDICommonBleReaderInvoker : global::Java.Lang.Object, IVDICommonBleReader {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/vdireader/VDICommonBleReader", typeof (IVDICommonBleReaderInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IVDICommonBleReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVDICommonBleReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.vdireader.VDICommonBleReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVDICommonBleReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LostThreshold = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLostThreshold;
		IntPtr id_setLostThreshold_I;
		public unsafe int LostThreshold {
			get {
				if (id_getLostThreshold == IntPtr.Zero)
					id_getLostThreshold = JNIEnv.GetMethodID (class_ref, "getLostThreshold", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLostThreshold);
			}
			set {
				if (id_setLostThreshold_I == IntPtr.Zero)
					id_setLostThreshold_I = JNIEnv.GetMethodID (class_ref, "setLostThreshold", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLostThreshold_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PDListLength;
		}
#pragma warning restore 0169

		IntPtr id_getPDListLength;
		public unsafe int PDListLength {
			get {
				if (id_getPDListLength == IntPtr.Zero)
					id_getPDListLength = JNIEnv.GetMethodID (class_ref, "getPDListLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPDListLength);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PairingRssi = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPairingRssi;
		IntPtr id_setPairingRssi_I;
		public unsafe int PairingRssi {
			get {
				if (id_getPairingRssi == IntPtr.Zero)
					id_getPairingRssi = JNIEnv.GetMethodID (class_ref, "getPairingRssi", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPairingRssi);
			}
			set {
				if (id_setPairingRssi_I == IntPtr.Zero)
					id_setPairingRssi_I = JNIEnv.GetMethodID (class_ref, "setPairingRssi", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPairingRssi_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPDList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addPDList_Ljava_lang_String_;
		public unsafe bool AddPDList (string p0)
		{
			if (id_addPDList_Ljava_lang_String_ == IntPtr.Zero)
				id_addPDList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPDList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addPDList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddPDList (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addPDList_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool AddPDList (string p0, string p1)
		{
			if (id_addPDList_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addPDList_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPDList", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addPDList_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckBle ());
		}
#pragma warning restore 0169

		IntPtr id_checkBle;
		public unsafe global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE CheckBle ()
		{
			if (id_checkBle == IntPtr.Zero)
				id_checkBle = JNIEnv.GetMethodID (class_ref, "checkBle", "()Lcom/vivalnk/vdireader/VDIType$CHECKBLE_STATUS_TYPE;");
			return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.VDIType.CHECKBLE_STATUS_TYPE> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkBle), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.IteratePDList ());
		}
#pragma warning restore 0169

		IntPtr id_iteratePDList;
		public unsafe global::System.Collections.Generic.IList<string> IteratePDList ()
		{
			if (id_iteratePDList == IntPtr.Zero)
				id_iteratePDList = JNIEnv.GetMethodID (class_ref, "iteratePDList", "()Ljava/util/ArrayList;");
			return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iteratePDList), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PurgePDList ();
		}
#pragma warning restore 0169

		IntPtr id_purgePDList;
		public unsafe void PurgePDList ()
		{
			if (id_purgePDList == IntPtr.Zero)
				id_purgePDList = JNIEnv.GetMethodID (class_ref, "purgePDList", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_purgePDList);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemovePDList (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removePDList_Ljava_lang_String_;
		public unsafe bool RemovePDList (string p0)
		{
			if (id_removePDList_Ljava_lang_String_ == IntPtr.Zero)
				id_removePDList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removePDList", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removePDList_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		IntPtr id_resume;
		public unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Vdireader.IVDICommonBleListener)global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_;
		public unsafe void SetListener (global::Com.Vivalnk.Vdireader.IVDICommonBleListener p0)
		{
			if (id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ == IntPtr.Zero)
				id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/vivalnk/vdireader/VDICommonBleListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_vivalnk_vdireader_VDICommonBleListener_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDeviceDiscovery ();
		}
#pragma warning restore 0169

		IntPtr id_startDeviceDiscovery;
		public unsafe void StartDeviceDiscovery ()
		{
			if (id_startDeviceDiscovery == IntPtr.Zero)
				id_startDeviceDiscovery = JNIEnv.GetMethodID (class_ref, "startDeviceDiscovery", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startDeviceDiscovery);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTemperatureUpdate ();
		}
#pragma warning restore 0169

		IntPtr id_startTemperatureUpdate;
		public unsafe void StartTemperatureUpdate ()
		{
			if (id_startTemperatureUpdate == IntPtr.Zero)
				id_startTemperatureUpdate = JNIEnv.GetMethodID (class_ref, "startTemperatureUpdate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startTemperatureUpdate);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDeviceDiscovery ();
		}
#pragma warning restore 0169

		IntPtr id_stopDeviceDiscovery;
		public unsafe void StopDeviceDiscovery ()
		{
			if (id_stopDeviceDiscovery == IntPtr.Zero)
				id_stopDeviceDiscovery = JNIEnv.GetMethodID (class_ref, "stopDeviceDiscovery", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopDeviceDiscovery);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTemperatureUpdate ();
		}
#pragma warning restore 0169

		IntPtr id_stopTemperatureUpdate;
		public unsafe void StopTemperatureUpdate ()
		{
			if (id_stopTemperatureUpdate == IntPtr.Zero)
				id_stopTemperatureUpdate = JNIEnv.GetMethodID (class_ref, "stopTemperatureUpdate", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopTemperatureUpdate);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Vdireader.IVDICommonBleReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Suspend ();
		}
#pragma warning restore 0169

		IntPtr id_suspend;
		public unsafe void Suspend ()
		{
			if (id_suspend == IntPtr.Zero)
				id_suspend = JNIEnv.GetMethodID (class_ref, "suspend", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_suspend);
		}

	}

}
