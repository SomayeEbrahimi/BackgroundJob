using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/base/RealCommand", DoNotGenerateAcw=true)]
	public abstract partial class RealCommand : global::Java.Lang.Object, global::Android.OS.Handler.ICallback {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "RealCommand";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='c']"
		[Register ("c")]
		public global::Com.Vivalnk.Sdk.CommandRequest C {
			get {
				const string __id = "c.Lcom/vivalnk/sdk/CommandRequest;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/vivalnk/sdk/CommandRequest;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='d']"
		[Register ("d")]
		public global::System.Collections.IDictionary D {
			get {
				const string __id = "d.Ljava/util/Map;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='e']"
		[Register ("e")]
		public global::Com.Vivalnk.Sdk.Model.Device E {
			get {
				const string __id = "e.Lcom/vivalnk/sdk/model/Device;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Lcom/vivalnk/sdk/model/Device;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='g']"
		[Register ("g")]
		public global::Android.OS.Handler G {
			get {
				const string __id = "g.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "g.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/field[@name='h']"
		[Register ("h")]
		public const int H = (int) 19;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/base/RealCommand", typeof (RealCommand));
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

		protected RealCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/constructor[@name='RealCommand' and count(parameter)=3 and parameter[1][@type='com.vivalnk.sdk.model.Device'] and parameter[2][@type='com.vivalnk.sdk.CommandRequest'] and parameter[3][@type='com.vivalnk.sdk.Callback']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/CommandRequest;Lcom/vivalnk/sdk/Callback;)V", "")]
		public unsafe RealCommand (global::Com.Vivalnk.Sdk.Model.Device p0, global::Com.Vivalnk.Sdk.CommandRequest p1, global::Com.Vivalnk.Sdk.ICallback p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/model/Device;Lcom/vivalnk/sdk/CommandRequest;Lcom/vivalnk/sdk/Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getDevice;
#pragma warning disable 0169
		static Delegate GetGetDeviceHandler ()
		{
			if (cb_getDevice == null)
				cb_getDevice = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDevice);
			return cb_getDevice;
		}

		static IntPtr n_GetDevice (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Device);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Model.Device Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Lcom/vivalnk/sdk/model/Device;", "GetGetDeviceHandler")]
			get {
				const string __id = "getDevice.()Lcom/vivalnk/sdk/model/Device;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Device> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isParameterOK;
#pragma warning disable 0169
		static Delegate GetIsParameterOKHandler ()
		{
			if (cb_isParameterOK == null)
				cb_isParameterOK = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsParameterOK);
			return cb_isParameterOK;
		}

		static bool n_IsParameterOK (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsParameterOK;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsParameterOK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='isParameterOK' and count(parameter)=0]"
			[Register ("isParameterOK", "()Z", "GetIsParameterOKHandler")]
			get {
				const string __id = "isParameterOK.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.CommandRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/vivalnk/sdk/CommandRequest;", "GetGetRequestHandler")]
			get {
				const string __id = "getRequest.()Lcom/vivalnk/sdk/CommandRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")] get;
		}

		static Delegate cb_getTypeName;
#pragma warning disable 0169
		static Delegate GetGetTypeNameHandler ()
		{
			if (cb_getTypeName == null)
				cb_getTypeName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeName);
			return cb_getTypeName;
		}

		static IntPtr n_GetTypeName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TypeName);
		}
#pragma warning restore 0169

		public virtual unsafe string TypeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getTypeName' and count(parameter)=0]"
			[Register ("getTypeName", "()Ljava/lang/String;", "GetGetTypeNameHandler")]
			get {
				const string __id = "getTypeName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_A);
			return cb_a;
		}

		static void n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "GetAHandler")]
		public virtual unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_a_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_A_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_);
			return cb_a_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_;
		}

		static bool n_A_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/String;)Z", "GetA_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_String_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe bool A (global::Java.Lang.Class p0, global::Java.Lang.Object p1, string p2)
		{
			const string __id = "a.(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/String;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_a_Ljava_lang_Object_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_Object_Ljava_lang_String_IHandler ()
		{
			if (cb_a_Ljava_lang_Object_Ljava_lang_String_I == null)
				cb_a_Ljava_lang_Object_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_A_Ljava_lang_Object_Ljava_lang_String_I);
			return cb_a_Ljava_lang_Object_Ljava_lang_String_I;
		}

		static bool n_A_Ljava_lang_Object_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("a", "(Ljava/lang/Object;Ljava/lang/String;I)Z", "GetA_Ljava_lang_Object_Ljava_lang_String_IHandler")]
		public virtual unsafe bool A (global::Java.Lang.Object p0, string p1, int p2)
		{
			const string __id = "a.(Ljava/lang/Object;Ljava/lang/String;I)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			const string __id = "execute.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getCheckSum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("getCheckSum", "([I)I", "")]
		public static unsafe int GetCheckSum (int[] p0)
		{
			const string __id = "getCheckSum.([I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getCheckSum' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getCheckSum", "([III)I", "")]
		public static unsafe int GetCheckSum (int[] p0, int p1, int p2)
		{
			const string __id = "getCheckSum.([III)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getRequestData;
#pragma warning disable 0169
		static Delegate GetGetRequestDataHandler ()
		{
			if (cb_getRequestData == null)
				cb_getRequestData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRequestData);
			return cb_getRequestData;
		}

		static IntPtr n_GetRequestData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRequestData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getRequestData' and count(parameter)=0]"
		[Register ("getRequestData", "()[B", "GetGetRequestDataHandler")]
		public abstract byte[] GetRequestData ();

		static Delegate cb_handleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_handleMessage_Landroid_os_Message_ == null)
				cb_handleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HandleMessage_Landroid_os_Message_);
			return cb_handleMessage_Landroid_os_Message_;
		}

		static bool n_HandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='handleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("handleMessage", "(Landroid/os/Message;)Z", "GetHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe bool HandleMessage (global::Android.OS.Message p0)
		{
			const string __id = "handleMessage.(Landroid/os/Message;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='initCheckSum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("initCheckSum", "([I)V", "")]
		public static unsafe void InitCheckSum (int[] p0)
		{
			const string __id = "initCheckSum.([I)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler")]
		public virtual unsafe void OnCancel ()
		{
			const string __id = "onCancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onCharacterWriteComplete_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCharacterWriteComplete_arrayBHandler ()
		{
			if (cb_onCharacterWriteComplete_arrayB == null)
				cb_onCharacterWriteComplete_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCharacterWriteComplete_arrayB);
			return cb_onCharacterWriteComplete_arrayB;
		}

		static void n_OnCharacterWriteComplete_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCharacterWriteComplete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onCharacterWriteComplete' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onCharacterWriteComplete", "([B)V", "GetOnCharacterWriteComplete_arrayBHandler")]
		public virtual unsafe void OnCharacterWriteComplete (byte[] p0)
		{
			const string __id = "onCharacterWriteComplete.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler")]
		public virtual unsafe void OnComplete ()
		{
			const string __id = "onComplete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onComplete_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Ljava_util_Map_Handler ()
		{
			if (cb_onComplete_Ljava_util_Map_ == null)
				cb_onComplete_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnComplete_Ljava_util_Map_);
			return cb_onComplete_Ljava_util_Map_;
		}

		static void n_OnComplete_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("onComplete", "(Ljava/util/Map;)V", "GetOnComplete_Ljava_util_Map_Handler")]
		public virtual unsafe void OnComplete (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "onComplete.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDataParseError_arrayB;
#pragma warning disable 0169
		static Delegate GetOnDataParseError_arrayBHandler ()
		{
			if (cb_onDataParseError_arrayB == null)
				cb_onDataParseError_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDataParseError_arrayB);
			return cb_onDataParseError_arrayB;
		}

		static void n_OnDataParseError_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnDataParseError (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onDataParseError' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onDataParseError", "([B)V", "GetOnDataParseError_arrayBHandler")]
		public virtual unsafe void OnDataParseError (byte[] p0)
		{
			const string __id = "onDataParseError.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_onError_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_ILjava_lang_String_Handler ()
		{
			if (cb_onError_ILjava_lang_String_ == null)
				cb_onError_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnError_ILjava_lang_String_);
			return cb_onError_ILjava_lang_String_;
		}

		static void n_OnError_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onError", "(ILjava/lang/String;)V", "GetOnError_ILjava_lang_String_Handler")]
		public virtual unsafe void OnError (int p0, string p1)
		{
			const string __id = "onError.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_onResponse_arrayB;
#pragma warning disable 0169
		static Delegate GetOnResponse_arrayBHandler ()
		{
			if (cb_onResponse_arrayB == null)
				cb_onResponse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResponse_arrayB);
			return cb_onResponse_arrayB;
		}

		static void n_OnResponse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnResponse (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onResponse", "([B)V", "GetOnResponse_arrayBHandler")]
		public abstract void OnResponse (byte[] p0);

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_parse_arrayB;
#pragma warning disable 0169
		static Delegate GetParse_arrayBHandler ()
		{
			if (cb_parse_arrayB == null)
				cb_parse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Parse_arrayB);
			return cb_parse_arrayB;
		}

		static void n_Parse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Parse (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parse", "([B)V", "GetParse_arrayBHandler")]
		public virtual unsafe void Parse (byte[] p0)
		{
			const string __id = "parse.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_parseResponse_arrayB;
#pragma warning disable 0169
		static Delegate GetParseResponse_arrayBHandler ()
		{
			if (cb_parseResponse_arrayB == null)
				cb_parseResponse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ParseResponse_arrayB);
			return cb_parseResponse_arrayB;
		}

		static void n_ParseResponse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Base.RealCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ParseResponse (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='parseResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseResponse", "([B)V", "GetParseResponse_arrayBHandler")]
		public virtual unsafe void ParseResponse (byte[] p0)
		{
			const string __id = "parseResponse.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/vivalnk/sdk/base/RealCommand", DoNotGenerateAcw=true)]
	internal partial class RealCommandInvoker : RealCommand {

		public RealCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/base/RealCommand", typeof (RealCommandInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='getRequestData' and count(parameter)=0]"
		[Register ("getRequestData", "()[B", "GetGetRequestDataHandler")]
		public override unsafe byte[] GetRequestData ()
		{
			const string __id = "getRequestData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.base']/class[@name='RealCommand']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onResponse", "([B)V", "GetOnResponse_arrayBHandler")]
		public override unsafe void OnResponse (byte[] p0)
		{
			const string __id = "onResponse.([B)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}

}
