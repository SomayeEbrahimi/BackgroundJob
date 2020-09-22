using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Observers {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']"
	[global::Android.Runtime.Register ("io/reactivex/observers/BaseTestConsumer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U extends io.reactivex.observers.BaseTestConsumer<T, U>"})]
	public abstract partial class BaseTestConsumer : global::Java.Lang.Object, global::IO.Reactivex.Disposables.IDisposable {


		static IntPtr checkSubscriptionOnce_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='checkSubscriptionOnce']"
		[Register ("checkSubscriptionOnce")]
		protected bool CheckSubscriptionOnce {
			get {
				if (checkSubscriptionOnce_jfieldId == IntPtr.Zero)
					checkSubscriptionOnce_jfieldId = JNIEnv.GetFieldID (class_ref, "checkSubscriptionOnce", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, checkSubscriptionOnce_jfieldId);
			}
			set {
				if (checkSubscriptionOnce_jfieldId == IntPtr.Zero)
					checkSubscriptionOnce_jfieldId = JNIEnv.GetFieldID (class_ref, "checkSubscriptionOnce", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, checkSubscriptionOnce_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr done_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='done']"
		[Register ("done")]
		protected global::Java.Util.Concurrent.CountDownLatch Done {
			get {
				if (done_jfieldId == IntPtr.Zero)
					done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Ljava/util/concurrent/CountDownLatch;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, done_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CountDownLatch> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (done_jfieldId == IntPtr.Zero)
					done_jfieldId = JNIEnv.GetFieldID (class_ref, "done", "Ljava/util/concurrent/CountDownLatch;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, done_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr establishedFusionMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='establishedFusionMode']"
		[Register ("establishedFusionMode")]
		protected int EstablishedFusionMode {
			get {
				if (establishedFusionMode_jfieldId == IntPtr.Zero)
					establishedFusionMode_jfieldId = JNIEnv.GetFieldID (class_ref, "establishedFusionMode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, establishedFusionMode_jfieldId);
			}
			set {
				if (establishedFusionMode_jfieldId == IntPtr.Zero)
					establishedFusionMode_jfieldId = JNIEnv.GetFieldID (class_ref, "establishedFusionMode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, establishedFusionMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr initialFusionMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='initialFusionMode']"
		[Register ("initialFusionMode")]
		protected int InitialFusionMode {
			get {
				if (initialFusionMode_jfieldId == IntPtr.Zero)
					initialFusionMode_jfieldId = JNIEnv.GetFieldID (class_ref, "initialFusionMode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, initialFusionMode_jfieldId);
			}
			set {
				if (initialFusionMode_jfieldId == IntPtr.Zero)
					initialFusionMode_jfieldId = JNIEnv.GetFieldID (class_ref, "initialFusionMode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, initialFusionMode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='tag']"
		[Register ("tag")]
		protected global::Java.Lang.ICharSequence Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/CharSequence;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tag_jfieldId);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/CharSequence;");
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timeout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/field[@name='timeout']"
		[Register ("timeout")]
		protected bool Timeout {
			get {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId);
			}
			set {
				if (timeout_jfieldId == IntPtr.Zero)
					timeout_jfieldId = JNIEnv.GetFieldID (class_ref, "timeout", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeout_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']"
		[global::Android.Runtime.Register ("io/reactivex/observers/BaseTestConsumer$TestWaitStrategy", DoNotGenerateAcw=true)]
		public abstract partial class TestWaitStrategy : global::Java.Lang.Enum, global::Java.Lang.IRunnable {


			static IntPtr SLEEP_1000MS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='SLEEP_1000MS']"
			[Register ("SLEEP_1000MS")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Sleep1000ms {
				get {
					if (SLEEP_1000MS_jfieldId == IntPtr.Zero)
						SLEEP_1000MS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SLEEP_1000MS", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SLEEP_1000MS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SLEEP_100MS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='SLEEP_100MS']"
			[Register ("SLEEP_100MS")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Sleep100ms {
				get {
					if (SLEEP_100MS_jfieldId == IntPtr.Zero)
						SLEEP_100MS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SLEEP_100MS", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SLEEP_100MS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SLEEP_10MS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='SLEEP_10MS']"
			[Register ("SLEEP_10MS")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Sleep10ms {
				get {
					if (SLEEP_10MS_jfieldId == IntPtr.Zero)
						SLEEP_10MS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SLEEP_10MS", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SLEEP_10MS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SLEEP_1MS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='SLEEP_1MS']"
			[Register ("SLEEP_1MS")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Sleep1ms {
				get {
					if (SLEEP_1MS_jfieldId == IntPtr.Zero)
						SLEEP_1MS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SLEEP_1MS", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SLEEP_1MS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SPIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='SPIN']"
			[Register ("SPIN")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Spin {
				get {
					if (SPIN_jfieldId == IntPtr.Zero)
						SPIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPIN", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr YIELD_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/field[@name='YIELD']"
			[Register ("YIELD")]
			public static global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy Yield {
				get {
					if (YIELD_jfieldId == IntPtr.Zero)
						YIELD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YIELD", "Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YIELD_jfieldId);
					return global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("io/reactivex/observers/BaseTestConsumer$TestWaitStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TestWaitStrategy); }
			}

			protected TestWaitStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public abstract void Run ();

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;", "")]
			public static unsafe global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy __ret = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;", "")]
			public static unsafe global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lio/reactivex/observers/BaseTestConsumer$TestWaitStrategy;");
				try {
					return (global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::IO.Reactivex.Observers.BaseTestConsumer.TestWaitStrategy));
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("io/reactivex/observers/BaseTestConsumer$TestWaitStrategy", DoNotGenerateAcw=true)]
		internal partial class TestWaitStrategyInvoker : TestWaitStrategy {

			public TestWaitStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TestWaitStrategyInvoker); }
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer.TestWaitStrategy']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				} finally {
				}
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/observers/BaseTestConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTestConsumer); }
		}

		protected BaseTestConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/constructor[@name='BaseTestConsumer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseTestConsumer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseTestConsumer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getEvents;
		public unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Java.Lang.Object>> Events {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='getEvents' and count(parameter)=0]"
			[Register ("getEvents", "()Ljava/util/List;", "")]
			get {
				if (id_getEvents == IntPtr.Zero)
					id_getEvents = JNIEnv.GetMethodID (class_ref, "getEvents", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Java.Lang.Object>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEvents), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isTerminated;
		public unsafe bool IsTerminated {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='isTerminated' and count(parameter)=0]"
			[Register ("isTerminated", "()Z", "")]
			get {
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID (class_ref, "isTerminated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTerminated);
				} finally {
				}
			}
		}

		static IntPtr id_isTimeout;
		public unsafe bool IsTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='isTimeout' and count(parameter)=0]"
			[Register ("isTimeout", "()Z", "")]
			get {
				if (id_isTimeout == IntPtr.Zero)
					id_isTimeout = JNIEnv.GetMethodID (class_ref, "isTimeout", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTimeout);
				} finally {
				}
			}
		}

		static IntPtr id_assertComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertComplete' and count(parameter)=0]"
		[Register ("assertComplete", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertComplete ()
		{
			if (id_assertComplete == IntPtr.Zero)
				id_assertComplete = JNIEnv.GetMethodID (class_ref, "assertComplete", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertComplete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertEmpty;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertEmpty' and count(parameter)=0]"
		[Register ("assertEmpty", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertEmpty ()
		{
			if (id_assertEmpty == IntPtr.Zero)
				id_assertEmpty = JNIEnv.GetMethodID (class_ref, "assertEmpty", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertEmpty), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertError_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertError' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;java.lang.Throwable&gt;']]"
		[Register ("assertError", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertError (global::IO.Reactivex.Functions.IPredicate errorPredicate)
		{
			if (id_assertError_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_assertError_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "assertError", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorPredicate);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertError_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertError_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertError' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;']]"
		[Register ("assertError", "(Ljava/lang/Class;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertError (global::Java.Lang.Class errorClass)
		{
			if (id_assertError_Ljava_lang_Class_ == IntPtr.Zero)
				id_assertError_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "assertError", "(Ljava/lang/Class;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (errorClass);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertError_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertError_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("assertError", "(Ljava/lang/Throwable;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertError (global::Java.Lang.Throwable error)
		{
			if (id_assertError_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_assertError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "assertError", "(Ljava/lang/Throwable;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertError_Ljava_lang_Throwable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertErrorMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertErrorMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("assertErrorMessage", "(Ljava/lang/String;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertErrorMessage (string message)
		{
			if (id_assertErrorMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_assertErrorMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "assertErrorMessage", "(Ljava/lang/String;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertErrorMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_assertFailure_Lio_reactivex_functions_Predicate_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertFailure' and count(parameter)=2 and parameter[1][@type='io.reactivex.functions.Predicate&lt;java.lang.Throwable&gt;'] and parameter[2][@type='T...']]"
		[Register ("assertFailure", "(Lio/reactivex/functions/Predicate;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertFailure (global::IO.Reactivex.Functions.IPredicate errorPredicate, params global::Java.Lang.Object[] values)
		{
			if (id_assertFailure_Lio_reactivex_functions_Predicate_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertFailure_Lio_reactivex_functions_Predicate_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertFailure", "(Lio/reactivex/functions/Predicate;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (errorPredicate);
				__args [1] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertFailure_Lio_reactivex_functions_Predicate_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_assertFailure_Ljava_lang_Class_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertFailure' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='T...']]"
		[Register ("assertFailure", "(Ljava/lang/Class;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertFailure (global::Java.Lang.Class error, params global::Java.Lang.Object[] values)
		{
			if (id_assertFailure_Ljava_lang_Class_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertFailure_Ljava_lang_Class_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertFailure", "(Ljava/lang/Class;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (error);
				__args [1] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertFailure_Ljava_lang_Class_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_assertFailureAndMessage_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertFailureAndMessage' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;? extends java.lang.Throwable&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='T...']]"
		[Register ("assertFailureAndMessage", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertFailureAndMessage (global::Java.Lang.Class error, string message, params global::Java.Lang.Object[] values)
		{
			if (id_assertFailureAndMessage_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertFailureAndMessage_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertFailureAndMessage", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (error);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertFailureAndMessage_Ljava_lang_Class_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_assertNever_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNever' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;? super T&gt;']]"
		[Register ("assertNever", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNever (global::IO.Reactivex.Functions.IPredicate valuePredicate)
		{
			if (id_assertNever_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_assertNever_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "assertNever", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valuePredicate);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNever_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertNever_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNever' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("assertNever", "(Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNever (global::Java.Lang.Object value)
		{
			if (id_assertNever_Ljava_lang_Object_ == IntPtr.Zero)
				id_assertNever_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertNever", "(Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNever_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_assertNoErrors;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNoErrors' and count(parameter)=0]"
		[Register ("assertNoErrors", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNoErrors ()
		{
			if (id_assertNoErrors == IntPtr.Zero)
				id_assertNoErrors = JNIEnv.GetMethodID (class_ref, "assertNoErrors", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNoErrors), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertNoTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNoTimeout' and count(parameter)=0]"
		[Register ("assertNoTimeout", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNoTimeout ()
		{
			if (id_assertNoTimeout == IntPtr.Zero)
				id_assertNoTimeout = JNIEnv.GetMethodID (class_ref, "assertNoTimeout", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNoTimeout), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertNoValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNoValues' and count(parameter)=0]"
		[Register ("assertNoValues", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNoValues ()
		{
			if (id_assertNoValues == IntPtr.Zero)
				id_assertNoValues = JNIEnv.GetMethodID (class_ref, "assertNoValues", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNoValues), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertNotComplete;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNotComplete' and count(parameter)=0]"
		[Register ("assertNotComplete", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNotComplete ()
		{
			if (id_assertNotComplete == IntPtr.Zero)
				id_assertNotComplete = JNIEnv.GetMethodID (class_ref, "assertNotComplete", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNotComplete), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_assertNotSubscribed;
#pragma warning disable 0169
		static Delegate GetAssertNotSubscribedHandler ()
		{
			if (cb_assertNotSubscribed == null)
				cb_assertNotSubscribed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AssertNotSubscribed);
			return cb_assertNotSubscribed;
		}

		static IntPtr n_AssertNotSubscribed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AssertNotSubscribed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNotSubscribed' and count(parameter)=0]"
		[Register ("assertNotSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;", "GetAssertNotSubscribedHandler")]
		public abstract global::Java.Lang.Object AssertNotSubscribed ();

		static IntPtr id_assertNotTerminated;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNotTerminated' and count(parameter)=0]"
		[Register ("assertNotTerminated", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertNotTerminated ()
		{
			if (id_assertNotTerminated == IntPtr.Zero)
				id_assertNotTerminated = JNIEnv.GetMethodID (class_ref, "assertNotTerminated", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNotTerminated), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertResult_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertResult' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("assertResult", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertResult (params global::Java.Lang.Object[] values)
		{
			if (id_assertResult_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertResult_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertResult", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertResult_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static Delegate cb_assertSubscribed;
#pragma warning disable 0169
		static Delegate GetAssertSubscribedHandler ()
		{
			if (cb_assertSubscribed == null)
				cb_assertSubscribed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AssertSubscribed);
			return cb_assertSubscribed;
		}

		static IntPtr n_AssertSubscribed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AssertSubscribed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertSubscribed' and count(parameter)=0]"
		[Register ("assertSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;", "GetAssertSubscribedHandler")]
		public abstract global::Java.Lang.Object AssertSubscribed ();

		static IntPtr id_assertTerminated;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertTerminated' and count(parameter)=0]"
		[Register ("assertTerminated", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertTerminated ()
		{
			if (id_assertTerminated == IntPtr.Zero)
				id_assertTerminated = JNIEnv.GetMethodID (class_ref, "assertTerminated", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertTerminated), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertTimeout' and count(parameter)=0]"
		[Register ("assertTimeout", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertTimeout ()
		{
			if (id_assertTimeout == IntPtr.Zero)
				id_assertTimeout = JNIEnv.GetMethodID (class_ref, "assertTimeout", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertTimeout), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertValue_Lio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValue' and count(parameter)=1 and parameter[1][@type='io.reactivex.functions.Predicate&lt;T&gt;']]"
		[Register ("assertValue", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValue (global::IO.Reactivex.Functions.IPredicate valuePredicate)
		{
			if (id_assertValue_Lio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_assertValue_Lio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "assertValue", "(Lio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (valuePredicate);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValue_Lio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValue' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("assertValue", "(Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValue (global::Java.Lang.Object value)
		{
			if (id_assertValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_assertValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertValue", "(Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValue_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_assertValueAt_ILio_reactivex_functions_Predicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='io.reactivex.functions.Predicate&lt;T&gt;']]"
		[Register ("assertValueAt", "(ILio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueAt (int index, global::IO.Reactivex.Functions.IPredicate valuePredicate)
		{
			if (id_assertValueAt_ILio_reactivex_functions_Predicate_ == IntPtr.Zero)
				id_assertValueAt_ILio_reactivex_functions_Predicate_ = JNIEnv.GetMethodID (class_ref, "assertValueAt", "(ILio/reactivex/functions/Predicate;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (valuePredicate);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueAt_ILio_reactivex_functions_Predicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertValueAt_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueAt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("assertValueAt", "(ILjava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueAt (int index, global::Java.Lang.Object value)
		{
			if (id_assertValueAt_ILjava_lang_Object_ == IntPtr.Zero)
				id_assertValueAt_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertValueAt", "(ILjava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_value);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueAt_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_assertValueCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("assertValueCount", "(I)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueCount (int count)
		{
			if (id_assertValueCount_I == IntPtr.Zero)
				id_assertValueCount_I = JNIEnv.GetMethodID (class_ref, "assertValueCount", "(I)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (count);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueCount_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertValueSequence_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueSequence' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("assertValueSequence", "(Ljava/lang/Iterable;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueSequence (global::Java.Lang.IIterable sequence)
		{
			if (id_assertValueSequence_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_assertValueSequence_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "assertValueSequence", "(Ljava/lang/Iterable;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sequence);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueSequence_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertValueSequenceOnly_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueSequenceOnly' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("assertValueSequenceOnly", "(Ljava/lang/Iterable;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueSequenceOnly (global::Java.Lang.IIterable sequence)
		{
			if (id_assertValueSequenceOnly_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_assertValueSequenceOnly_Ljava_lang_Iterable_ = JNIEnv.GetMethodID (class_ref, "assertValueSequenceOnly", "(Ljava/lang/Iterable;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sequence);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueSequenceOnly_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_assertValueSet_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueSet' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends T&gt;']]"
		[Register ("assertValueSet", "(Ljava/util/Collection;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueSet (global::System.Collections.ICollection expected)
		{
			if (id_assertValueSet_Ljava_util_Collection_ == IntPtr.Zero)
				id_assertValueSet_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "assertValueSet", "(Ljava/util/Collection;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_expected = global::Android.Runtime.JavaCollection.ToLocalJniHandle (expected);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_expected);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueSet_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_expected);
			}
		}

		static IntPtr id_assertValueSetOnly_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValueSetOnly' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends T&gt;']]"
		[Register ("assertValueSetOnly", "(Ljava/util/Collection;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValueSetOnly (global::System.Collections.ICollection expected)
		{
			if (id_assertValueSetOnly_Ljava_util_Collection_ == IntPtr.Zero)
				id_assertValueSetOnly_Ljava_util_Collection_ = JNIEnv.GetMethodID (class_ref, "assertValueSetOnly", "(Ljava/util/Collection;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_expected = global::Android.Runtime.JavaCollection.ToLocalJniHandle (expected);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_expected);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValueSetOnly_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_expected);
			}
		}

		static IntPtr id_assertValues_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValues' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("assertValues", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValues (params global::Java.Lang.Object[] values)
		{
			if (id_assertValues_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertValues_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertValues", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValues_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_assertValuesOnly_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertValuesOnly' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("assertValuesOnly", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AssertValuesOnly (params global::Java.Lang.Object[] values)
		{
			if (id_assertValuesOnly_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_assertValuesOnly_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "assertValuesOnly", "([Ljava/lang/Object;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_values);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertValuesOnly_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		static IntPtr id_await;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='await' and count(parameter)=0]"
		[Register ("await", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object Await ()
		{
			if (id_await == IntPtr.Zero)
				id_await = JNIEnv.GetMethodID (class_ref, "await", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_await), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_await_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='await' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("await", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public unsafe bool Await (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_await_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_await_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_await_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_awaitCount_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("awaitCount", "(I)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AwaitCount (int atLeast)
		{
			if (id_awaitCount_I == IntPtr.Zero)
				id_awaitCount_I = JNIEnv.GetMethodID (class_ref, "awaitCount", "(I)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (atLeast);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_awaitCount_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_awaitCount_ILjava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("awaitCount", "(ILjava/lang/Runnable;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AwaitCount (int atLeast, global::Java.Lang.IRunnable waitStrategy)
		{
			if (id_awaitCount_ILjava_lang_Runnable_ == IntPtr.Zero)
				id_awaitCount_ILjava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "awaitCount", "(ILjava/lang/Runnable;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (atLeast);
				__args [1] = new JValue (waitStrategy);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_awaitCount_ILjava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_awaitCount_ILjava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitCount' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Runnable'] and parameter[3][@type='long']]"
		[Register ("awaitCount", "(ILjava/lang/Runnable;J)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AwaitCount (int atLeast, global::Java.Lang.IRunnable waitStrategy, long timeoutMillis)
		{
			if (id_awaitCount_ILjava_lang_Runnable_J == IntPtr.Zero)
				id_awaitCount_ILjava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "awaitCount", "(ILjava/lang/Runnable;J)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (atLeast);
				__args [1] = new JValue (waitStrategy);
				__args [2] = new JValue (timeoutMillis);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_awaitCount_ILjava_lang_Runnable_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_awaitDone_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitDone' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitDone", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object AwaitDone (long time, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_awaitDone_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitDone_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "awaitDone", "(JLjava/util/concurrent/TimeUnit;)Lio/reactivex/observers/BaseTestConsumer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (time);
				__args [1] = new JValue (unit);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_awaitDone_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_awaitTerminalEvent;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitTerminalEvent' and count(parameter)=0]"
		[Register ("awaitTerminalEvent", "()Z", "")]
		public unsafe bool AwaitTerminalEvent ()
		{
			if (id_awaitTerminalEvent == IntPtr.Zero)
				id_awaitTerminalEvent = JNIEnv.GetMethodID (class_ref, "awaitTerminalEvent", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_awaitTerminalEvent);
			} finally {
			}
		}

		static IntPtr id_awaitTerminalEvent_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='awaitTerminalEvent' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitTerminalEvent", "(JLjava/util/concurrent/TimeUnit;)Z", "")]
		public unsafe bool AwaitTerminalEvent (long duration, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_awaitTerminalEvent_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitTerminalEvent_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "awaitTerminalEvent", "(JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (duration);
				__args [1] = new JValue (unit);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_awaitTerminalEvent_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_clearTimeout;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='clearTimeout' and count(parameter)=0]"
		[Register ("clearTimeout", "()Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object ClearTimeout ()
		{
			if (id_clearTimeout == IntPtr.Zero)
				id_clearTimeout = JNIEnv.GetMethodID (class_ref, "clearTimeout", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clearTimeout), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_completions;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='completions' and count(parameter)=0]"
		[Register ("completions", "()J", "")]
		public unsafe long Completions ()
		{
			if (id_completions == IntPtr.Zero)
				id_completions = JNIEnv.GetMethodID (class_ref, "completions", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_completions);
			} finally {
			}
		}

		static IntPtr id_errorCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='errorCount' and count(parameter)=0]"
		[Register ("errorCount", "()I", "")]
		public unsafe int ErrorCount ()
		{
			if (id_errorCount == IntPtr.Zero)
				id_errorCount = JNIEnv.GetMethodID (class_ref, "errorCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_errorCount);
			} finally {
			}
		}

		static IntPtr id_errors;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='errors' and count(parameter)=0]"
		[Register ("errors", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Throwable> Errors ()
		{
			if (id_errors == IntPtr.Zero)
				id_errors = JNIEnv.GetMethodID (class_ref, "errors", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Lang.Throwable>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_errors), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_fail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='fail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fail", "(Ljava/lang/String;)Ljava/lang/AssertionError;", "")]
		protected unsafe global::Java.Lang.AssertionError Fail (string message)
		{
			if (id_fail_Ljava_lang_String_ == IntPtr.Zero)
				id_fail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fail", "(Ljava/lang/String;)Ljava/lang/AssertionError;");
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				global::Java.Lang.AssertionError __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.AssertionError> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fail_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_lastThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='lastThread' and count(parameter)=0]"
		[Register ("lastThread", "()Ljava/lang/Thread;", "")]
		public unsafe global::Java.Lang.Thread LastThread ()
		{
			if (id_lastThread == IntPtr.Zero)
				id_lastThread = JNIEnv.GetMethodID (class_ref, "lastThread", "()Ljava/lang/Thread;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_lastThread), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueAndClass_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='valueAndClass' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("valueAndClass", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ValueAndClass (global::Java.Lang.Object o)
		{
			if (id_valueAndClass_Ljava_lang_Object_ == IntPtr.Zero)
				id_valueAndClass_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "valueAndClass", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (o);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueAndClass_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_valueCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='valueCount' and count(parameter)=0]"
		[Register ("valueCount", "()I", "")]
		public unsafe int ValueCount ()
		{
			if (id_valueCount == IntPtr.Zero)
				id_valueCount = JNIEnv.GetMethodID (class_ref, "valueCount", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_valueCount);
			} finally {
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.IList Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetMethodID (class_ref, "values", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_values), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_withTag_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='withTag' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("withTag", "(Ljava/lang/CharSequence;)Lio/reactivex/observers/BaseTestConsumer;", "")]
		public unsafe global::Java.Lang.Object WithTag (global::Java.Lang.ICharSequence tag)
		{
			if (id_withTag_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_withTag_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "withTag", "(Ljava/lang/CharSequence;)Lio/reactivex/observers/BaseTestConsumer;");
			IntPtr native_tag = CharSequence.ToLocalJniHandle (tag);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_tag);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withTag_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		public global::Java.Lang.Object WithTag (string tag)
		{
			var jls_tag = tag == null ? null : new global::Java.Lang.String (tag);
			global::Java.Lang.Object __result = WithTag (jls_tag);
			var __rsval = __result;
			jls_tag?.Dispose ();
			return __rsval;
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/interface[@name='Disposable']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public abstract void Dispose ();

		static Delegate cb_isDisposed;
#pragma warning disable 0169
		static Delegate GetIsDisposedHandler ()
		{
			if (cb_isDisposed == null)
				cb_isDisposed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDisposed);
			return cb_isDisposed;
		}

		static bool n_IsDisposed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Observers.BaseTestConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisposed;
		}
#pragma warning restore 0169

		public abstract bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("io/reactivex/observers/BaseTestConsumer", DoNotGenerateAcw=true)]
	internal partial class BaseTestConsumerInvoker : BaseTestConsumer {

		public BaseTestConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTestConsumerInvoker); }
		}

		static IntPtr id_assertNotSubscribed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertNotSubscribed' and count(parameter)=0]"
		[Register ("assertNotSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;", "GetAssertNotSubscribedHandler")]
		public override unsafe global::Java.Lang.Object AssertNotSubscribed ()
		{
			if (id_assertNotSubscribed == IntPtr.Zero)
				id_assertNotSubscribed = JNIEnv.GetMethodID (class_ref, "assertNotSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertNotSubscribed), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_assertSubscribed;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='assertSubscribed' and count(parameter)=0]"
		[Register ("assertSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;", "GetAssertSubscribedHandler")]
		public override unsafe global::Java.Lang.Object AssertSubscribed ()
		{
			if (id_assertSubscribed == IntPtr.Zero)
				id_assertSubscribed = JNIEnv.GetMethodID (class_ref, "assertSubscribed", "()Lio/reactivex/observers/BaseTestConsumer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_assertSubscribed), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_isDisposed;
		public override unsafe bool IsDisposed {
			// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.observers']/class[@name='BaseTestConsumer']/method[@name='isDisposed' and count(parameter)=0]"
			[Register ("isDisposed", "()Z", "GetIsDisposedHandler")]
			get {
				if (id_isDisposed == IntPtr.Zero)
					id_isDisposed = JNIEnv.GetMethodID (class_ref, "isDisposed", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisposed);
				} finally {
				}
			}
		}

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.disposables']/interface[@name='Disposable']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
			} finally {
			}
		}

	}

}
