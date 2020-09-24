using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/CommandRequest", DoNotGenerateAcw=true)]
	public partial class CommandRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/field[@name='DEFAULT_MIN_TIME_OUT']"
		[Register ("DEFAULT_MIN_TIME_OUT")]
		public static int DefaultMinTimeOut {
			get {
				const string __id = "DEFAULT_MIN_TIME_OUT.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "DEFAULT_MIN_TIME_OUT.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/field[@name='loggable']"
		[Register ("loggable")]
		public bool Loggable {
			get {
				const string __id = "loggable.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "loggable.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/CommandRequest$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/field[@name='loggable']"
			[Register ("loggable")]
			public bool Loggable {
				get {
					const string __id = "loggable.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "loggable.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/field[@name='params']"
			[Register ("params")]
			public global::System.Collections.IDictionary Params {
				get {
					const string __id = "params.Ljava/util/Map;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "params.Ljava/util/Map;";

					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/field[@name='timeout']"
			[Register ("timeout")]
			public long Timeout {
				get {
					const string __id = "timeout.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "timeout.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/field[@name='type']"
			[Register ("type")]
			public int Type {
				get {
					const string __id = "type.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "type.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/CommandRequest$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/constructor[@name='CommandRequest.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='addParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
			[Register ("addParam", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/vivalnk/sdk/CommandRequest$Builder;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest.Builder AddParam (string p0, global::Java.Lang.Object p1)
			{
				const string __id = "addParam.(Ljava/lang/String;Ljava/lang/Object;)Lcom/vivalnk/sdk/CommandRequest$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='addParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("addParams", "(Ljava/util/Map;)Lcom/vivalnk/sdk/CommandRequest$Builder;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest.Builder AddParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				const string __id = "addParams.(Ljava/util/Map;)Lcom/vivalnk/sdk/CommandRequest$Builder;";
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/vivalnk/sdk/CommandRequest;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest Build ()
			{
				const string __id = "build.()Lcom/vivalnk/sdk/CommandRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='setLoggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLoggable", "(Z)Lcom/vivalnk/sdk/CommandRequest$Builder;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest.Builder SetLoggable (bool p0)
			{
				const string __id = "setLoggable.(Z)Lcom/vivalnk/sdk/CommandRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTimeout", "(J)Lcom/vivalnk/sdk/CommandRequest$Builder;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest.Builder SetTimeout (long p0)
			{
				const string __id = "setTimeout.(J)Lcom/vivalnk/sdk/CommandRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest.Builder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)Lcom/vivalnk/sdk/CommandRequest$Builder;", "")]
			public unsafe global::Com.Vivalnk.Sdk.CommandRequest.Builder SetType (int p0)
			{
				const string __id = "setType.(I)Lcom/vivalnk/sdk/CommandRequest$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/CommandRequest", typeof (CommandRequest));
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

		protected CommandRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/constructor[@name='CommandRequest' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.CommandRequest.Builder']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/CommandRequest$Builder;)V", "")]
		public unsafe CommandRequest (global::Com.Vivalnk.Sdk.CommandRequest.Builder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/CommandRequest$Builder;)V";

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

		static Delegate cb_isLoggable;
#pragma warning disable 0169
		static Delegate GetIsLoggableHandler ()
		{
			if (cb_isLoggable == null)
				cb_isLoggable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLoggable);
			return cb_isLoggable;
		}

		static bool n_IsLoggable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggable;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLoggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/method[@name='isLoggable' and count(parameter)=0]"
			[Register ("isLoggable", "()Z", "GetIsLoggableHandler")]
			get {
				const string __id = "isLoggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler")]
			get {
				const string __id = "getParams.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeout;
#pragma warning disable 0169
		static Delegate GetGetTimeoutHandler ()
		{
			if (cb_getTimeout == null)
				cb_getTimeout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTimeout);
			return cb_getTimeout;
		}

		static long n_GetTimeout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeout;
		}
#pragma warning restore 0169

		public virtual unsafe long Timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/method[@name='getTimeout' and count(parameter)=0]"
			[Register ("getTimeout", "()J", "GetGetTimeoutHandler")]
			get {
				const string __id = "getTimeout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.CommandRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TypeName);
		}
#pragma warning restore 0169

		public virtual unsafe string TypeName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk']/class[@name='CommandRequest']/method[@name='getTypeName' and count(parameter)=0]"
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

	}
}
