using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Repository.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/EventData", DoNotGenerateAcw=true)]
	public partial class EventData : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/field[@name='app_id']"
		[Register ("app_id")]
		public string AppId {
			get {
				const string __id = "app_id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "app_id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/field[@name='networkType']"
		[Register ("networkType")]
		public string NetworkType {
			get {
				const string __id = "networkType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "networkType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/field[@name='patchMessage']"
		[Register ("patchMessage")]
		public string PatchMessage {
			get {
				const string __id = "patchMessage.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "patchMessage.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/field[@name='profileId']"
		[Register ("profileId")]
		public string ProfileId {
			get {
				const string __id = "profileId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "profileId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/EventData$AuditTrailBean", DoNotGenerateAcw=true)]
		public partial class AuditTrailBean : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/EventData$AuditTrailBean", typeof (AuditTrailBean));
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

			protected AuditTrailBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']/constructor[@name='EventData.AuditTrailBean' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AuditTrailBean ()
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

			static Delegate cb_getBar;
#pragma warning disable 0169
			static Delegate GetGetBarHandler ()
			{
				if (cb_getBar == null)
					cb_getBar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBar);
				return cb_getBar;
			}

			static IntPtr n_GetBar (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Bar);
			}
#pragma warning restore 0169

			static Delegate cb_setBar_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBar_Ljava_lang_String_Handler ()
			{
				if (cb_setBar_Ljava_lang_String_ == null)
					cb_setBar_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBar_Ljava_lang_String_);
				return cb_setBar_Ljava_lang_String_;
			}

			static void n_SetBar_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Bar = p0;
			}
#pragma warning restore 0169

			public virtual unsafe string Bar {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']/method[@name='getBar' and count(parameter)=0]"
				[Register ("getBar", "()Ljava/lang/String;", "GetGetBarHandler")]
				get {
					const string __id = "getBar.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']/method[@name='setBar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setBar", "(Ljava/lang/String;)V", "GetSetBar_Ljava_lang_String_Handler")]
				set {
					const string __id = "setBar.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getFoo;
#pragma warning disable 0169
			static Delegate GetGetFooHandler ()
			{
				if (cb_getFoo == null)
					cb_getFoo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFoo);
				return cb_getFoo;
			}

			static IntPtr n_GetFoo (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Foo);
			}
#pragma warning restore 0169

			static Delegate cb_setFoo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFoo_Ljava_lang_String_Handler ()
			{
				if (cb_setFoo_Ljava_lang_String_ == null)
					cb_setFoo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFoo_Ljava_lang_String_);
				return cb_setFoo_Ljava_lang_String_;
			}

			static void n_SetFoo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Foo = p0;
			}
#pragma warning restore 0169

			public virtual unsafe string Foo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']/method[@name='getFoo' and count(parameter)=0]"
				[Register ("getFoo", "()Ljava/lang/String;", "GetGetFooHandler")]
				get {
					const string __id = "getFoo.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.AuditTrailBean']/method[@name='setFoo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setFoo", "(Ljava/lang/String;)V", "GetSetFoo_Ljava_lang_String_Handler")]
				set {
					const string __id = "setFoo.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.DataBean']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/EventData$DataBean", DoNotGenerateAcw=true)]
		public partial class DataBean : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/EventData$DataBean", typeof (DataBean));
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

			protected DataBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.DataBean']/constructor[@name='EventData.DataBean' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DataBean ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/repository/model/EventData$TagsBean", DoNotGenerateAcw=true)]
		public partial class TagsBean : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/EventData$TagsBean", typeof (TagsBean));
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

			protected TagsBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']/constructor[@name='EventData.TagsBean' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe TagsBean ()
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

			static Delegate cb_getBar;
#pragma warning disable 0169
			static Delegate GetGetBarHandler ()
			{
				if (cb_getBar == null)
					cb_getBar = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBar);
				return cb_getBar;
			}

			static IntPtr n_GetBar (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Bar);
			}
#pragma warning restore 0169

			static Delegate cb_setBar_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetBar_Ljava_lang_String_Handler ()
			{
				if (cb_setBar_Ljava_lang_String_ == null)
					cb_setBar_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBar_Ljava_lang_String_);
				return cb_setBar_Ljava_lang_String_;
			}

			static void n_SetBar_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Bar = p0;
			}
#pragma warning restore 0169

			public virtual unsafe string Bar {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']/method[@name='getBar' and count(parameter)=0]"
				[Register ("getBar", "()Ljava/lang/String;", "GetGetBarHandler")]
				get {
					const string __id = "getBar.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']/method[@name='setBar' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setBar", "(Ljava/lang/String;)V", "GetSetBar_Ljava_lang_String_Handler")]
				set {
					const string __id = "setBar.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getFoo;
#pragma warning disable 0169
			static Delegate GetGetFooHandler ()
			{
				if (cb_getFoo == null)
					cb_getFoo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFoo);
				return cb_getFoo;
			}

			static IntPtr n_GetFoo (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Foo);
			}
#pragma warning restore 0169

			static Delegate cb_setFoo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFoo_Ljava_lang_String_Handler ()
			{
				if (cb_setFoo_Ljava_lang_String_ == null)
					cb_setFoo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFoo_Ljava_lang_String_);
				return cb_setFoo_Ljava_lang_String_;
			}

			static void n_SetFoo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Foo = p0;
			}
#pragma warning restore 0169

			public virtual unsafe string Foo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']/method[@name='getFoo' and count(parameter)=0]"
				[Register ("getFoo", "()Ljava/lang/String;", "GetGetFooHandler")]
				get {
					const string __id = "getFoo.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData.TagsBean']/method[@name='setFoo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setFoo", "(Ljava/lang/String;)V", "GetSetFoo_Ljava_lang_String_Handler")]
				set {
					const string __id = "setFoo.(Ljava/lang/String;)V";
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/repository/model/EventData", typeof (EventData));
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

		protected EventData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/constructor[@name='EventData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/repository/local/database/VitalData;)V", "")]
		public unsafe EventData (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/repository/local/database/VitalData;)V";

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

		static Delegate cb_getAppID;
#pragma warning disable 0169
		static Delegate GetGetAppIDHandler ()
		{
			if (cb_getAppID == null)
				cb_getAppID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppID);
			return cb_getAppID;
		}

		static IntPtr n_GetAppID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				const string __id = "getAppID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAuditTrail;
#pragma warning disable 0169
		static Delegate GetGetAuditTrailHandler ()
		{
			if (cb_getAuditTrail == null)
				cb_getAuditTrail = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAuditTrail);
			return cb_getAuditTrail;
		}

		static IntPtr n_GetAuditTrail (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean>.ToLocalJniHandle (__this.AuditTrail);
		}
#pragma warning restore 0169

		static Delegate cb_setAuditTrail_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAuditTrail_Ljava_util_List_Handler ()
		{
			if (cb_setAuditTrail_Ljava_util_List_ == null)
				cb_setAuditTrail_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAuditTrail_Ljava_util_List_);
			return cb_setAuditTrail_Ljava_util_List_;
		}

		static void n_SetAuditTrail_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuditTrail = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean> AuditTrail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getAuditTrail' and count(parameter)=0]"
			[Register ("getAuditTrail", "()Ljava/util/List;", "GetGetAuditTrailHandler")]
			get {
				const string __id = "getAuditTrail.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setAuditTrail' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.repository.model.EventData.AuditTrailBean&gt;']]"
			[Register ("setAuditTrail", "(Ljava/util/List;)V", "GetSetAuditTrail_Ljava_util_List_Handler")]
			set {
				const string __id = "setAuditTrail.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.AuditTrailBean>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCarrier;
#pragma warning disable 0169
		static Delegate GetGetCarrierHandler ()
		{
			if (cb_getCarrier == null)
				cb_getCarrier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCarrier);
			return cb_getCarrier;
		}

		static IntPtr n_GetCarrier (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Carrier);
		}
#pragma warning restore 0169

		static Delegate cb_setCarrier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCarrier_Ljava_lang_String_Handler ()
		{
			if (cb_setCarrier_Ljava_lang_String_ == null)
				cb_setCarrier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCarrier_Ljava_lang_String_);
			return cb_setCarrier_Ljava_lang_String_;
		}

		static void n_SetCarrier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Carrier = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Carrier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getCarrier' and count(parameter)=0]"
			[Register ("getCarrier", "()Ljava/lang/String;", "GetGetCarrierHandler")]
			get {
				const string __id = "getCarrier.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setCarrier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCarrier", "(Ljava/lang/String;)V", "GetSetCarrier_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCarrier.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCategory;
#pragma warning disable 0169
		static Delegate GetGetCategoryHandler ()
		{
			if (cb_getCategory == null)
				cb_getCategory = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCategory);
			return cb_getCategory;
		}

		static IntPtr n_GetCategory (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Category);
		}
#pragma warning restore 0169

		static Delegate cb_setCategory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCategory_Ljava_lang_String_Handler ()
		{
			if (cb_setCategory_Ljava_lang_String_ == null)
				cb_setCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCategory_Ljava_lang_String_);
			return cb_setCategory_Ljava_lang_String_;
		}

		static void n_SetCategory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Category = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Category {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getCategory' and count(parameter)=0]"
			[Register ("getCategory", "()Ljava/lang/String;", "GetGetCategoryHandler")]
			get {
				const string __id = "getCategory.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setCategory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCategory", "(Ljava/lang/String;)V", "GetSetCategory_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCategory.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCollectTime;
#pragma warning disable 0169
		static Delegate GetGetCollectTimeHandler ()
		{
			if (cb_getCollectTime == null)
				cb_getCollectTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCollectTime);
			return cb_getCollectTime;
		}

		static IntPtr n_GetCollectTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CollectTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCollectTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCollectTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setCollectTime_Ljava_lang_Long_ == null)
				cb_setCollectTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCollectTime_Ljava_lang_Long_);
			return cb_setCollectTime_Ljava_lang_Long_;
		}

		static void n_SetCollectTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CollectTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long CollectTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getCollectTime' and count(parameter)=0]"
			[Register ("getCollectTime", "()Ljava/lang/Long;", "GetGetCollectTimeHandler")]
			get {
				const string __id = "getCollectTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setCollectTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCollectTime", "(Ljava/lang/Long;)V", "GetSetCollectTime_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setCollectTime.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static Delegate cb_setContext_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetContext_Ljava_util_Map_Handler ()
		{
			if (cb_setContext_Ljava_util_Map_ == null)
				cb_setContext_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContext_Ljava_util_Map_);
			return cb_setContext_Ljava_util_Map_;
		}

		static void n_SetContext_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Context = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Ljava/util/Map;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setContext", "(Ljava/util/Map;)V", "GetSetContext_Ljava_util_Map_Handler")]
			set {
				const string __id = "setContext.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomData;
#pragma warning disable 0169
		static Delegate GetGetCustomDataHandler ()
		{
			if (cb_getCustomData == null)
				cb_getCustomData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCustomData);
			return cb_getCustomData;
		}

		static IntPtr n_GetCustomData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.CustomData);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomData_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetCustomData_Ljava_util_Map_Handler ()
		{
			if (cb_setCustomData_Ljava_util_Map_ == null)
				cb_setCustomData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCustomData_Ljava_util_Map_);
			return cb_setCustomData_Ljava_util_Map_;
		}

		static void n_SetCustomData_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CustomData = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> CustomData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getCustomData' and count(parameter)=0]"
			[Register ("getCustomData", "()Ljava/util/Map;", "GetGetCustomDataHandler")]
			get {
				const string __id = "getCustomData.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setCustomData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setCustomData", "(Ljava/util/Map;)V", "GetSetCustomData_Ljava_util_Map_Handler")]
			set {
				const string __id = "setCustomData.(Ljava/util/Map;)V";
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_Handler ()
		{
			if (cb_setData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_ == null)
				cb_setData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_);
			return cb_setData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_;
		}

		static void n_SetData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormatedNet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Data = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormatedNet Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Data.DataJsonConverter.DataFormatedNet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.data.DataJsonConverter.DataFormatedNet']]"
			[Register ("setData", "(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet;)V", "GetSetData_Lcom_vivalnk_sdk_data_DataJsonConverter_DataFormatedNet_Handler")]
			set {
				const string __id = "setData.(Lcom/vivalnk/sdk/data/DataJsonConverter$DataFormatedNet;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceBattery;
#pragma warning disable 0169
		static Delegate GetGetDeviceBatteryHandler ()
		{
			if (cb_getDeviceBattery == null)
				cb_getDeviceBattery = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetDeviceBattery);
			return cb_getDeviceBattery;
		}

		static double n_GetDeviceBattery (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceBattery;
		}
#pragma warning restore 0169

		public virtual unsafe double DeviceBattery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceBattery' and count(parameter)=0]"
			[Register ("getDeviceBattery", "()D", "GetGetDeviceBatteryHandler")]
			get {
				const string __id = "getDeviceBattery.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceIp;
#pragma warning disable 0169
		static Delegate GetGetDeviceIpHandler ()
		{
			if (cb_getDeviceIp == null)
				cb_getDeviceIp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceIp);
			return cb_getDeviceIp;
		}

		static IntPtr n_GetDeviceIp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceIp);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceIp_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceIp_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceIp_Ljava_lang_String_ == null)
				cb_setDeviceIp_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceIp_Ljava_lang_String_);
			return cb_setDeviceIp_Ljava_lang_String_;
		}

		static void n_SetDeviceIp_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceIp = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceIp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceIp' and count(parameter)=0]"
			[Register ("getDeviceIp", "()Ljava/lang/String;", "GetGetDeviceIpHandler")]
			get {
				const string __id = "getDeviceIp.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceIp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceIp", "(Ljava/lang/String;)V", "GetSetDeviceIp_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceIp.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceOsType;
#pragma warning disable 0169
		static Delegate GetGetDeviceOsTypeHandler ()
		{
			if (cb_getDeviceOsType == null)
				cb_getDeviceOsType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceOsType);
			return cb_getDeviceOsType;
		}

		static IntPtr n_GetDeviceOsType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOsType);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceOsType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceOsType_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceOsType_Ljava_lang_String_ == null)
				cb_setDeviceOsType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceOsType_Ljava_lang_String_);
			return cb_setDeviceOsType_Ljava_lang_String_;
		}

		static void n_SetDeviceOsType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceOsType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceOsType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceOsType' and count(parameter)=0]"
			[Register ("getDeviceOsType", "()Ljava/lang/String;", "GetGetDeviceOsTypeHandler")]
			get {
				const string __id = "getDeviceOsType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceOsType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceOsType", "(Ljava/lang/String;)V", "GetSetDeviceOsType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceOsType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceOsVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceOsVersionHandler ()
		{
			if (cb_getDeviceOsVersion == null)
				cb_getDeviceOsVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceOsVersion);
			return cb_getDeviceOsVersion;
		}

		static IntPtr n_GetDeviceOsVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceOsVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceOsVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceOsVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceOsVersion_Ljava_lang_String_ == null)
				cb_setDeviceOsVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceOsVersion_Ljava_lang_String_);
			return cb_setDeviceOsVersion_Ljava_lang_String_;
		}

		static void n_SetDeviceOsVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceOsVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceOsVersion' and count(parameter)=0]"
			[Register ("getDeviceOsVersion", "()Ljava/lang/String;", "GetGetDeviceOsVersionHandler")]
			get {
				const string __id = "getDeviceOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceOsVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceOsVersion", "(Ljava/lang/String;)V", "GetSetDeviceOsVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceOsVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceToken;
#pragma warning disable 0169
		static Delegate GetGetDeviceTokenHandler ()
		{
			if (cb_getDeviceToken == null)
				cb_getDeviceToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceToken);
			return cb_getDeviceToken;
		}

		static IntPtr n_GetDeviceToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceToken);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceToken_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceToken_Ljava_lang_String_ == null)
				cb_setDeviceToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceToken_Ljava_lang_String_);
			return cb_setDeviceToken_Ljava_lang_String_;
		}

		static void n_SetDeviceToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceToken = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceToken' and count(parameter)=0]"
			[Register ("getDeviceToken", "()Ljava/lang/String;", "GetGetDeviceTokenHandler")]
			get {
				const string __id = "getDeviceToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceToken", "(Ljava/lang/String;)V", "GetSetDeviceToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceToken.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceType);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceType_Ljava_lang_String_ == null)
				cb_setDeviceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceType_Ljava_lang_String_);
			return cb_setDeviceType_Ljava_lang_String_;
		}

		static void n_SetDeviceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Ljava/lang/String;", "GetGetDeviceTypeHandler")]
			get {
				const string __id = "getDeviceType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceType", "(Ljava/lang/String;)V", "GetSetDeviceType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_setLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setLanguage_Ljava_lang_String_ == null)
				cb_setLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLanguage_Ljava_lang_String_);
			return cb_setLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Language = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLanguage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				const string __id = "setLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongtitude;
#pragma warning disable 0169
		static Delegate GetGetLongtitudeHandler ()
		{
			if (cb_getLongtitude == null)
				cb_getLongtitude = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetLongtitude);
			return cb_getLongtitude;
		}

		static double n_GetLongtitude (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longtitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongtitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongtitude_DHandler ()
		{
			if (cb_setLongtitude_D == null)
				cb_setLongtitude_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetLongtitude_D);
			return cb_setLongtitude_D;
		}

		static void n_SetLongtitude_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longtitude = p0;
		}
#pragma warning restore 0169

		public virtual unsafe double Longtitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getLongtitude' and count(parameter)=0]"
			[Register ("getLongtitude", "()D", "GetGetLongtitudeHandler")]
			get {
				const string __id = "getLongtitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setLongtitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongtitude", "(D)V", "GetSetLongtitude_DHandler")]
			set {
				const string __id = "setLongtitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProfileIdX;
#pragma warning disable 0169
		static Delegate GetGetProfileIdXHandler ()
		{
			if (cb_getProfileIdX == null)
				cb_getProfileIdX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfileIdX);
			return cb_getProfileIdX;
		}

		static IntPtr n_GetProfileIdX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileIdX);
		}
#pragma warning restore 0169

		static Delegate cb_setProfileIdX_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProfileIdX_Ljava_lang_String_Handler ()
		{
			if (cb_setProfileIdX_Ljava_lang_String_ == null)
				cb_setProfileIdX_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProfileIdX_Ljava_lang_String_);
			return cb_setProfileIdX_Ljava_lang_String_;
		}

		static void n_SetProfileIdX_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProfileIdX = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ProfileIdX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getProfileIdX' and count(parameter)=0]"
			[Register ("getProfileIdX", "()Ljava/lang/String;", "GetGetProfileIdXHandler")]
			get {
				const string __id = "getProfileIdX.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setProfileIdX' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProfileIdX", "(Ljava/lang/String;)V", "GetSetProfileIdX_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProfileIdX.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReceiveTime;
#pragma warning disable 0169
		static Delegate GetGetReceiveTimeHandler ()
		{
			if (cb_getReceiveTime == null)
				cb_getReceiveTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReceiveTime);
			return cb_getReceiveTime;
		}

		static IntPtr n_GetReceiveTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReceiveTime);
		}
#pragma warning restore 0169

		static Delegate cb_setReceiveTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetReceiveTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setReceiveTime_Ljava_lang_Long_ == null)
				cb_setReceiveTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetReceiveTime_Ljava_lang_Long_);
			return cb_setReceiveTime_Ljava_lang_Long_;
		}

		static void n_SetReceiveTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiveTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long ReceiveTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getReceiveTime' and count(parameter)=0]"
			[Register ("getReceiveTime", "()Ljava/lang/Long;", "GetGetReceiveTimeHandler")]
			get {
				const string __id = "getReceiveTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setReceiveTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setReceiveTime", "(Ljava/lang/Long;)V", "GetSetReceiveTime_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setReceiveTime.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordTime;
#pragma warning disable 0169
		static Delegate GetGetRecordTimeHandler ()
		{
			if (cb_getRecordTime == null)
				cb_getRecordTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecordTime);
			return cb_getRecordTime;
		}

		static IntPtr n_GetRecordTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RecordTime);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetRecordTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setRecordTime_Ljava_lang_Long_ == null)
				cb_setRecordTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRecordTime_Ljava_lang_Long_);
			return cb_setRecordTime_Ljava_lang_Long_;
		}

		static void n_SetRecordTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RecordTime = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Long RecordTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getRecordTime' and count(parameter)=0]"
			[Register ("getRecordTime", "()Ljava/lang/Long;", "GetGetRecordTimeHandler")]
			get {
				const string __id = "getRecordTime.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setRecordTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setRecordTime", "(Ljava/lang/Long;)V", "GetSetRecordTime_Ljava_lang_Long_Handler")]
			set {
				const string __id = "setRecordTime.(Ljava/lang/Long;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static IntPtr n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setSdkVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSdkVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setSdkVersion_Ljava_lang_String_ == null)
				cb_setSdkVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSdkVersion_Ljava_lang_String_);
			return cb_setSdkVersion_Ljava_lang_String_;
		}

		static void n_SetSdkVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SdkVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				const string __id = "getSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setSdkVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSdkVersion", "(Ljava/lang/String;)V", "GetSetSdkVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSdkVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSensorId;
#pragma warning disable 0169
		static Delegate GetGetSensorIdHandler ()
		{
			if (cb_getSensorId == null)
				cb_getSensorId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSensorId);
			return cb_getSensorId;
		}

		static IntPtr n_GetSensorId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SensorId);
		}
#pragma warning restore 0169

		static Delegate cb_setSensorId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSensorId_Ljava_lang_String_Handler ()
		{
			if (cb_setSensorId_Ljava_lang_String_ == null)
				cb_setSensorId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSensorId_Ljava_lang_String_);
			return cb_setSensorId_Ljava_lang_String_;
		}

		static void n_SetSensorId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SensorId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SensorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getSensorId' and count(parameter)=0]"
			[Register ("getSensorId", "()Ljava/lang/String;", "GetGetSensorIdHandler")]
			get {
				const string __id = "getSensorId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setSensorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSensorId", "(Ljava/lang/String;)V", "GetSetSensorId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSensorId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTags;
#pragma warning disable 0169
		static Delegate GetGetTagsHandler ()
		{
			if (cb_getTags == null)
				cb_getTags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTags);
			return cb_getTags;
		}

		static IntPtr n_GetTags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean>.ToLocalJniHandle (__this.Tags);
		}
#pragma warning restore 0169

		static Delegate cb_setTags_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetTags_Ljava_util_List_Handler ()
		{
			if (cb_setTags_Ljava_util_List_ == null)
				cb_setTags_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTags_Ljava_util_List_);
			return cb_setTags_Ljava_util_List_;
		}

		static void n_SetTags_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean> Tags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getTags' and count(parameter)=0]"
			[Register ("getTags", "()Ljava/util/List;", "GetGetTagsHandler")]
			get {
				const string __id = "getTags.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setTags' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.repository.model.EventData.TagsBean&gt;']]"
			[Register ("setTags", "(Ljava/util/List;)V", "GetSetTags_Ljava_util_List_Handler")]
			set {
				const string __id = "setTags.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Repository.Model.EventData.TagsBean>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimezone;
#pragma warning disable 0169
		static Delegate GetGetTimezoneHandler ()
		{
			if (cb_getTimezone == null)
				cb_getTimezone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimezone);
			return cb_getTimezone;
		}

		static IntPtr n_GetTimezone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Timezone);
		}
#pragma warning restore 0169

		static Delegate cb_setTimezone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTimezone_Ljava_lang_String_Handler ()
		{
			if (cb_setTimezone_Ljava_lang_String_ == null)
				cb_setTimezone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTimezone_Ljava_lang_String_);
			return cb_setTimezone_Ljava_lang_String_;
		}

		static void n_SetTimezone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Timezone = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Timezone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getTimezone' and count(parameter)=0]"
			[Register ("getTimezone", "()Ljava/lang/String;", "GetGetTimezoneHandler")]
			get {
				const string __id = "getTimezone.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setTimezone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTimezone", "(Ljava/lang/String;)V", "GetSetTimezone_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTimezone.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='getDeviceInfoInMap' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.repository.local.database.VitalData']]"
		[Register ("getDeviceInfoInMap", "(Lcom/vivalnk/sdk/repository/local/database/VitalData;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceInfoInMap (global::Com.Vivalnk.Sdk.Repository.Local.Database.VitalData p0)
		{
			const string __id = "getDeviceInfoInMap.(Lcom/vivalnk/sdk/repository/local/database/VitalData;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDeviceBattery_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetDeviceBattery_Ljava_lang_Integer_Handler ()
		{
			if (cb_setDeviceBattery_Ljava_lang_Integer_ == null)
				cb_setDeviceBattery_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceBattery_Ljava_lang_Integer_);
			return cb_setDeviceBattery_Ljava_lang_Integer_;
		}

		static void n_SetDeviceBattery_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDeviceBattery (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setDeviceBattery' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setDeviceBattery", "(Ljava/lang/Integer;)V", "GetSetDeviceBattery_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SetDeviceBattery (global::Java.Lang.Integer p0)
		{
			const string __id = "setDeviceBattery.(Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setgetAppID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetgetAppID_Ljava_lang_String_Handler ()
		{
			if (cb_setgetAppID_Ljava_lang_String_ == null)
				cb_setgetAppID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetgetAppID_Ljava_lang_String_);
			return cb_setgetAppID_Ljava_lang_String_;
		}

		static void n_SetgetAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Repository.Model.EventData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetgetAppID (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.repository.model']/class[@name='EventData']/method[@name='setgetAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setgetAppID", "(Ljava/lang/String;)V", "GetSetgetAppID_Ljava_lang_String_Handler")]
		public virtual unsafe void SetgetAppID (string p0)
		{
			const string __id = "setgetAppID.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
