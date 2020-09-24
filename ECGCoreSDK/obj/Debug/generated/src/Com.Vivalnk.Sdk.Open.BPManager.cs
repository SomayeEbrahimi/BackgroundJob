using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/open/BPManager", DoNotGenerateAcw=true)]
	public partial class BPManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "BPManager";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='a']"
		[Register ("a")]
		public global::Com.Vivalnk.Sdk.Model.Person A {
			get {
				const string __id = "a.Lcom/vivalnk/sdk/model/Person;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Person> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/vivalnk/sdk/model/Person;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='b']"
		[Register ("b")]
		public global::Java.Util.Concurrent.CopyOnWriteArrayList B {
			get {
				const string __id = "b.Ljava/util/concurrent/CopyOnWriteArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/util/concurrent/CopyOnWriteArrayList;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='c']"
		[Register ("c")]
		public global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener C {
			get {
				const string __id = "c.Lcom/vivalnk/sdk/open/BPManager$BPResultListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/vivalnk/sdk/open/BPManager$BPResultListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='d']"
		[Register ("d")]
		public global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread D {
			get {
				const string __id = "d.Lcom/vivalnk/sdk/core/bp/StackHandlerThread;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Core.BP.StackHandlerThread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Lcom/vivalnk/sdk/core/bp/StackHandlerThread;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='e']"
		[Register ("e")]
		public global::Android.OS.Handler E {
			get {
				const string __id = "e.Landroid/os/Handler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Landroid/os/Handler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='f']"
		[Register ("f")]
		public int F {
			get {
				const string __id = "f.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "f.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='g']"
		[Register ("g")]
		public int G {
			get {
				const string __id = "g.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "g.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='h']"
		[Register ("h")]
		public global::Java.Lang.Object H {
			get {
				const string __id = "h.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "h.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='i']"
		[Register ("i")]
		public global::Com.Vivalnk.Sdk.Open.BPManager.CalRunnable I {
			get {
				const string __id = "i.Lcom/vivalnk/sdk/open/BPManager$CalRunnable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.CalRunnable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "i.Lcom/vivalnk/sdk/open/BPManager$CalRunnable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='j']"
		[Register ("j")]
		public global::Java.Lang.IRunnable J {
			get {
				const string __id = "j.Ljava/lang/Runnable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "j.Ljava/lang/Runnable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='k']"
		[Register ("k")]
		public const int K = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='l']"
		[Register ("l")]
		public const string L = (string) "key_sys_cal";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/field[@name='m']"
		[Register ("m")]
		public const string M = (string) "key_dia_cal";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='BPManager.BPResultListener']"
		[Register ("com/vivalnk/sdk/open/BPManager$BPResultListener", "", "Com.Vivalnk.Sdk.Open.BPManager/IBPResultListenerInvoker")]
		public partial interface IBPResultListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='BPManager.BPResultListener']/method[@name='onBPData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.open.BloodPressure']]"
			[Register ("onBPData", "(Lcom/vivalnk/sdk/open/BloodPressure;)V", "GetOnBPData_Lcom_vivalnk_sdk_open_BloodPressure_Handler:Com.Vivalnk.Sdk.Open.BPManager/IBPResultListenerInvoker, ECGCoreSDK")]
			void OnBPData (global::Com.Vivalnk.Sdk.Open.BloodPressure p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='BPManager.BPResultListener']/method[@name='onCalibrateInitComplete' and count(parameter)=0]"
			[Register ("onCalibrateInitComplete", "()V", "GetOnCalibrateInitCompleteHandler:Com.Vivalnk.Sdk.Open.BPManager/IBPResultListenerInvoker, ECGCoreSDK")]
			void OnCalibrateInitComplete ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='BPManager.BPResultListener']/method[@name='onCalibrateInitStart' and count(parameter)=0]"
			[Register ("onCalibrateInitStart", "()V", "GetOnCalibrateInitStartHandler:Com.Vivalnk.Sdk.Open.BPManager/IBPResultListenerInvoker, ECGCoreSDK")]
			void OnCalibrateInitStart ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/interface[@name='BPManager.BPResultListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Vivalnk.Sdk.Open.BPManager/IBPResultListenerInvoker, ECGCoreSDK")]
			void OnError (global::Java.Lang.Throwable p0);

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/open/BPManager$BPResultListener", DoNotGenerateAcw=true)]
		internal partial class IBPResultListenerInvoker : global::Java.Lang.Object, IBPResultListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/BPManager$BPResultListener", typeof (IBPResultListenerInvoker));

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

			public static IBPResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBPResultListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.vivalnk.sdk.open.BPManager.BPResultListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBPResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_;
#pragma warning disable 0169
			static Delegate GetOnBPData_Lcom_vivalnk_sdk_open_BloodPressure_Handler ()
			{
				if (cb_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_ == null)
					cb_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBPData_Lcom_vivalnk_sdk_open_BloodPressure_);
				return cb_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_;
			}

			static void n_OnBPData_Lcom_vivalnk_sdk_open_BloodPressure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BloodPressure> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBPData (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_;
			public unsafe void OnBPData (global::Com.Vivalnk.Sdk.Open.BloodPressure p0)
			{
				if (id_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_ == IntPtr.Zero)
					id_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_ = JNIEnv.GetMethodID (class_ref, "onBPData", "(Lcom/vivalnk/sdk/open/BloodPressure;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBPData_Lcom_vivalnk_sdk_open_BloodPressure_, __args);
			}

			static Delegate cb_onCalibrateInitComplete;
#pragma warning disable 0169
			static Delegate GetOnCalibrateInitCompleteHandler ()
			{
				if (cb_onCalibrateInitComplete == null)
					cb_onCalibrateInitComplete = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCalibrateInitComplete);
				return cb_onCalibrateInitComplete;
			}

			static void n_OnCalibrateInitComplete (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCalibrateInitComplete ();
			}
#pragma warning restore 0169

			IntPtr id_onCalibrateInitComplete;
			public unsafe void OnCalibrateInitComplete ()
			{
				if (id_onCalibrateInitComplete == IntPtr.Zero)
					id_onCalibrateInitComplete = JNIEnv.GetMethodID (class_ref, "onCalibrateInitComplete", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCalibrateInitComplete);
			}

			static Delegate cb_onCalibrateInitStart;
#pragma warning disable 0169
			static Delegate GetOnCalibrateInitStartHandler ()
			{
				if (cb_onCalibrateInitStart == null)
					cb_onCalibrateInitStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCalibrateInitStart);
				return cb_onCalibrateInitStart;
			}

			static void n_OnCalibrateInitStart (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCalibrateInitStart ();
			}
#pragma warning restore 0169

			IntPtr id_onCalibrateInitStart;
			public unsafe void OnCalibrateInitStart ()
			{
				if (id_onCalibrateInitStart == IntPtr.Zero)
					id_onCalibrateInitStart = JNIEnv.GetMethodID (class_ref, "onCalibrateInitStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCalibrateInitStart);
			}

			static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onError_Ljava_lang_Throwable_ == null)
					cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_Throwable_);
				return cb_onError_Ljava_lang_Throwable_;
			}

			static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_Throwable_;
			public unsafe void OnError (global::Java.Lang.Throwable p0)
			{
				if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			}

		}

		// event args for com.vivalnk.sdk.open.BPManager.BPResultListener.onBPData
		public partial class BPDataEventArgs : global::System.EventArgs {

			public BPDataEventArgs (global::Com.Vivalnk.Sdk.Open.BloodPressure p0)
			{
				this.p0 = p0;
			}

			global::Com.Vivalnk.Sdk.Open.BloodPressure p0;
			public global::Com.Vivalnk.Sdk.Open.BloodPressure P0 {
				get { return p0; }
			}
		}

		// event args for com.vivalnk.sdk.open.BPManager.BPResultListener.onError
		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Java.Lang.Throwable p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Throwable p0;
			public global::Java.Lang.Throwable P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/vivalnk/sdk/open/BPManager_BPResultListenerImplementor")]
		internal sealed partial class IBPResultListenerImplementor : global::Java.Lang.Object, IBPResultListener {

			object sender;

			public IBPResultListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/vivalnk/sdk/open/BPManager_BPResultListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BPDataEventArgs> OnBPDataHandler;
#pragma warning restore 0649

			public void OnBPData (global::Com.Vivalnk.Sdk.Open.BloodPressure p0)
			{
				var __h = OnBPDataHandler;
				if (__h != null)
					__h (sender, new BPDataEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnCalibrateInitCompleteHandler;
#pragma warning restore 0649

			public void OnCalibrateInitComplete ()
			{
				var __h = OnCalibrateInitCompleteHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnCalibrateInitStartHandler;
#pragma warning restore 0649

			public void OnCalibrateInitStart ()
			{
				var __h = OnCalibrateInitStartHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (global::Java.Lang.Throwable p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IBPResultListenerImplementor value)
			{
				return value.OnBPDataHandler == null && value.OnCalibrateInitCompleteHandler == null && value.OnCalibrateInitStartHandler == null && value.OnErrorHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/open/BPManager$CalRunnable", DoNotGenerateAcw=true)]
		public partial class CalRunnable : global::Java.Lang.Object, global::Java.Lang.IRunnable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/field[@name='a']"
			[Register ("a")]
			public int A {
				get {
					const string __id = "a.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "a.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/field[@name='b']"
			[Register ("b")]
			public int B {
				get {
					const string __id = "b.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "b.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/field[@name='c']"
			[Register ("c")]
			public global::Com.Vivalnk.Sdk.Open.BPManager C {
				get {
					const string __id = "c.Lcom/vivalnk/sdk/open/BPManager;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "c.Lcom/vivalnk/sdk/open/BPManager;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/BPManager$CalRunnable", typeof (CalRunnable));
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

			protected CalRunnable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/constructor[@name='BPManager.CalRunnable' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.open.BPManager']]"
			[Register (".ctor", "(Lcom/vivalnk/sdk/open/BPManager;)V", "")]
			public unsafe CalRunnable (global::Com.Vivalnk.Sdk.Open.BPManager __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.CalRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_setBP_Cal_II;
#pragma warning disable 0169
			static Delegate GetSetBP_Cal_IIHandler ()
			{
				if (cb_setBP_Cal_II == null)
					cb_setBP_Cal_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetBP_Cal_II);
				return cb_setBP_Cal_II;
			}

			static void n_SetBP_Cal_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager.CalRunnable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetBP_Cal (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager.CalRunnable']/method[@name='setBP_Cal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setBP_Cal", "(II)V", "GetSetBP_Cal_IIHandler")]
			public virtual unsafe void SetBP_Cal (int p0, int p1)
			{
				const string __id = "setBP_Cal.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/BPManager", typeof (BPManager));
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

		protected BPManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/constructor[@name='BPManager' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.open.BPManager.BPResultListener']]"
		[Register (".ctor", "(Lcom/vivalnk/sdk/open/BPManager$BPResultListener;)V", "")]
		public unsafe BPManager (global::Com.Vivalnk.Sdk.Open.BPManager.IBPResultListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/vivalnk/sdk/open/BPManager$BPResultListener;)V";

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

		static Delegate cb_addSampleData_Lcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAddSampleData_Lcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_addSampleData_Lcom_vivalnk_sdk_model_SampleData_ == null)
				cb_addSampleData_Lcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddSampleData_Lcom_vivalnk_sdk_model_SampleData_);
			return cb_addSampleData_Lcom_vivalnk_sdk_model_SampleData_;
		}

		static bool n_AddSampleData_Lcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.SampleData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddSampleData (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/method[@name='addSampleData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData']]"
		[Register ("addSampleData", "(Lcom/vivalnk/sdk/model/SampleData;)Z", "GetAddSampleData_Lcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe bool AddSampleData (global::Com.Vivalnk.Sdk.Model.SampleData p0)
		{
			const string __id = "addSampleData.(Lcom/vivalnk/sdk/model/SampleData;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_estimiate_bp;
#pragma warning disable 0169
		static Delegate GetEstimiate_bpHandler ()
		{
			if (cb_estimiate_bp == null)
				cb_estimiate_bp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Estimiate_bp);
			return cb_estimiate_bp;
		}

		static void n_Estimiate_bp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Estimiate_bp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/method[@name='estimiate_bp' and count(parameter)=0]"
		[Register ("estimiate_bp", "()V", "GetEstimiate_bpHandler")]
		public virtual unsafe void Estimiate_bp ()
		{
			const string __id = "estimiate_bp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initCalibrationData_II;
#pragma warning disable 0169
		static Delegate GetInitCalibrationData_IIHandler ()
		{
			if (cb_initCalibrationData_II == null)
				cb_initCalibrationData_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_InitCalibrationData_II);
			return cb_initCalibrationData_II;
		}

		static void n_InitCalibrationData_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCalibrationData (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/method[@name='initCalibrationData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initCalibrationData", "(II)V", "GetInitCalibrationData_IIHandler")]
		public virtual unsafe void InitCalibrationData (int p0, int p1)
		{
			const string __id = "initCalibrationData.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_;
#pragma warning disable 0169
		static Delegate GetInitUserInfo_Lcom_vivalnk_sdk_model_Person_Handler ()
		{
			if (cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_ == null)
				cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InitUserInfo_Lcom_vivalnk_sdk_model_Person_);
			return cb_initUserInfo_Lcom_vivalnk_sdk_model_Person_;
		}

		static bool n_InitUserInfo_Lcom_vivalnk_sdk_model_Person_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.BPManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Model.Person> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InitUserInfo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='BPManager']/method[@name='initUserInfo' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.Person']]"
		[Register ("initUserInfo", "(Lcom/vivalnk/sdk/model/Person;)Z", "GetInitUserInfo_Lcom_vivalnk_sdk_model_Person_Handler")]
		public virtual unsafe bool InitUserInfo (global::Com.Vivalnk.Sdk.Model.Person p0)
		{
			const string __id = "initUserInfo.(Lcom/vivalnk/sdk/model/Person;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
