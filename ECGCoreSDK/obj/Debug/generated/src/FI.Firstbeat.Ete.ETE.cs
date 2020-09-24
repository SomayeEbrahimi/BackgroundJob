using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FI.Firstbeat.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']"
	[global::Android.Runtime.Register ("fi/firstbeat/ete/ETE", DoNotGenerateAcw=true)]
	public partial class ETE : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/field[@name='mInstance']"
		[Register ("mInstance")]
		public long MInstance {
			get {
				const string __id = "mInstance.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mInstance.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("fi/firstbeat/ete/ETE", typeof (ETE));
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

		protected ETE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/constructor[@name='ETE' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ETE ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/constructor[@name='ETE' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ETE (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getInstanceId;
#pragma warning disable 0169
		static Delegate GetGetInstanceIdHandler ()
		{
			if (cb_getInstanceId == null)
				cb_getInstanceId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetInstanceId);
			return cb_getInstanceId;
		}

		static long n_GetInstanceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InstanceId;
		}
#pragma warning restore 0169

		public virtual unsafe long InstanceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='getInstanceId' and count(parameter)=0]"
			[Register ("getInstanceId", "()J", "GetGetInstanceIdHandler")]
			get {
				const string __id = "getInstanceId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_;
#pragma warning disable 0169
		static Delegate GetAnalyzerStruct_Lfi_firstbeat_ete_FBTinput_Handler ()
		{
			if (cb_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_ == null)
				cb_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_);
			return cb_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_;
		}

		static int n_AnalyzerStruct_Lfi_firstbeat_ete_FBTinput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.FBTinput> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AnalyzerStruct (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='AnalyzerStruct' and count(parameter)=1 and parameter[1][@type='fi.firstbeat.ete.FBTinput']]"
		[Register ("AnalyzerStruct", "(Lfi/firstbeat/ete/FBTinput;)I", "GetAnalyzerStruct_Lfi_firstbeat_ete_FBTinput_Handler")]
		public virtual unsafe int AnalyzerStruct (global::FI.Firstbeat.Ete.FBTinput p0)
		{
			const string __id = "AnalyzerStruct.(Lfi/firstbeat/ete/FBTinput;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ETEVersion;
#pragma warning disable 0169
		static Delegate GetETEVersionHandler ()
		{
			if (cb_ETEVersion == null)
				cb_ETEVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ETEVersion);
			return cb_ETEVersion;
		}

		static IntPtr n_ETEVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ETEVersion ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='ETEVersion' and count(parameter)=0]"
		[Register ("ETEVersion", "()Ljava/lang/String;", "GetETEVersionHandler")]
		public virtual unsafe string ETEVersion ()
		{
			const string __id = "ETEVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_GetResult_Lfi_firstbeat_ete_ETEresults_;
#pragma warning disable 0169
		static Delegate GetGetResult_Lfi_firstbeat_ete_ETEresults_Handler ()
		{
			if (cb_GetResult_Lfi_firstbeat_ete_ETEresults_ == null)
				cb_GetResult_Lfi_firstbeat_ete_ETEresults_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetResult_Lfi_firstbeat_ete_ETEresults_);
			return cb_GetResult_Lfi_firstbeat_ete_ETEresults_;
		}

		static int n_GetResult_Lfi_firstbeat_ete_ETEresults_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETEresults> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetResult (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='GetResult' and count(parameter)=1 and parameter[1][@type='fi.firstbeat.ete.ETEresults']]"
		[Register ("GetResult", "(Lfi/firstbeat/ete/ETEresults;)I", "GetGetResult_Lfi_firstbeat_ete_ETEresults_Handler")]
		public virtual unsafe int GetResult (global::FI.Firstbeat.Ete.ETEresults p0)
		{
			const string __id = "GetResult.(Lfi/firstbeat/ete/ETEresults;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_SetExercise_Lfi_firstbeat_ete_FBTexercise_;
#pragma warning disable 0169
		static Delegate GetSetExercise_Lfi_firstbeat_ete_FBTexercise_Handler ()
		{
			if (cb_SetExercise_Lfi_firstbeat_ete_FBTexercise_ == null)
				cb_SetExercise_Lfi_firstbeat_ete_FBTexercise_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_SetExercise_Lfi_firstbeat_ete_FBTexercise_);
			return cb_SetExercise_Lfi_firstbeat_ete_FBTexercise_;
		}

		static int n_SetExercise_Lfi_firstbeat_ete_FBTexercise_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.FBTexercise> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetExercise (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='SetExercise' and count(parameter)=1 and parameter[1][@type='fi.firstbeat.ete.FBTexercise']]"
		[Register ("SetExercise", "(Lfi/firstbeat/ete/FBTexercise;)I", "GetSetExercise_Lfi_firstbeat_ete_FBTexercise_Handler")]
		public virtual unsafe int SetExercise (global::FI.Firstbeat.Ete.FBTexercise p0)
		{
			const string __id = "SetExercise.(Lfi/firstbeat/ete/FBTexercise;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_SetParameters_Lfi_firstbeat_ete_FBTvars_I;
#pragma warning disable 0169
		static Delegate GetSetParameters_Lfi_firstbeat_ete_FBTvars_IHandler ()
		{
			if (cb_SetParameters_Lfi_firstbeat_ete_FBTvars_I == null)
				cb_SetParameters_Lfi_firstbeat_ete_FBTvars_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_SetParameters_Lfi_firstbeat_ete_FBTvars_I);
			return cb_SetParameters_Lfi_firstbeat_ete_FBTvars_I;
		}

		static int n_SetParameters_Lfi_firstbeat_ete_FBTvars_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.FBTvars> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetParameters (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='SetParameters' and count(parameter)=2 and parameter[1][@type='fi.firstbeat.ete.FBTvars'] and parameter[2][@type='int']]"
		[Register ("SetParameters", "(Lfi/firstbeat/ete/FBTvars;I)I", "GetSetParameters_Lfi_firstbeat_ete_FBTvars_IHandler")]
		public virtual unsafe int SetParameters (global::FI.Firstbeat.Ete.FBTvars p0, int p1)
		{
			const string __id = "SetParameters.(Lfi/firstbeat/ete/FBTvars;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_SetWalkingTest_Z;
#pragma warning disable 0169
		static Delegate GetSetWalkingTest_ZHandler ()
		{
			if (cb_SetWalkingTest_Z == null)
				cb_SetWalkingTest_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetWalkingTest_Z);
			return cb_SetWalkingTest_Z;
		}

		static void n_SetWalkingTest_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWalkingTest (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='SetWalkingTest' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetWalkingTest", "(Z)V", "GetSetWalkingTest_ZHandler")]
		public virtual unsafe void SetWalkingTest (bool p0)
		{
			const string __id = "SetWalkingTest.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getInstance;
#pragma warning disable 0169
		static Delegate GetGetInstanceHandler ()
		{
			if (cb_getInstance == null)
				cb_getInstance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInstance);
			return cb_getInstance;
		}

		static IntPtr n_GetInstance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::FI.Firstbeat.Ete.ETE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInstance ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='fi.firstbeat.ete']/class[@name='ETE']/method[@name='getInstance' and count(parameter)=0]"
		[Register ("getInstance", "()[B", "GetGetInstanceHandler")]
		public virtual unsafe byte[] GetInstance ()
		{
			const string __id = "getInstance.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
