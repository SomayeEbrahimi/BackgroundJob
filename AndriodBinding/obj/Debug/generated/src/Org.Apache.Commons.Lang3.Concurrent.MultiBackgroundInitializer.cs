using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/MultiBackgroundInitializer", DoNotGenerateAcw=true)]
	public partial class MultiBackgroundInitializer : global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/MultiBackgroundInitializer$MultiBackgroundInitializerResults", DoNotGenerateAcw=true)]
		public partial class MultiBackgroundInitializerResults : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/MultiBackgroundInitializer$MultiBackgroundInitializerResults", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MultiBackgroundInitializerResults); }
			}

			protected MultiBackgroundInitializerResults (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isSuccessful;
#pragma warning disable 0169
			static Delegate GetIsSuccessfulHandler ()
			{
				if (cb_isSuccessful == null)
					cb_isSuccessful = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccessful);
				return cb_isSuccessful;
			}

			static bool n_IsSuccessful (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsSuccessful;
			}
#pragma warning restore 0169

			static IntPtr id_isSuccessful;
			public virtual unsafe bool IsSuccessful {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='isSuccessful' and count(parameter)=0]"
				[Register ("isSuccessful", "()Z", "GetIsSuccessfulHandler")]
				get {
					if (id_isSuccessful == IntPtr.Zero)
						id_isSuccessful = JNIEnv.GetMethodID (class_ref, "isSuccessful", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccessful);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccessful", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getException_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetException_Ljava_lang_String_Handler ()
			{
				if (cb_getException_Ljava_lang_String_ == null)
					cb_getException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetException_Ljava_lang_String_);
				return cb_getException_Ljava_lang_String_;
			}

			static IntPtr n_GetException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetException (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getException_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='getException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getException", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/ConcurrentException;", "GetGetException_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException GetException (string name)
			{
				if (id_getException_Ljava_lang_String_ == IntPtr.Zero)
					id_getException_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getException", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/ConcurrentException;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getException_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.ConcurrentException> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getException", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/ConcurrentException;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_getInitializer_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetInitializer_Ljava_lang_String_Handler ()
			{
				if (cb_getInitializer_Ljava_lang_String_ == null)
					cb_getInitializer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetInitializer_Ljava_lang_String_);
				return cb_getInitializer_Ljava_lang_String_;
			}

			static IntPtr n_GetInitializer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInitializer (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getInitializer_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='getInitializer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getInitializer", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;", "GetGetInitializer_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer GetInitializer (string name)
			{
				if (id_getInitializer_Ljava_lang_String_ == IntPtr.Zero)
					id_getInitializer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInitializer", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInitializer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitializer", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_getResultObject_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetResultObject_Ljava_lang_String_Handler ()
			{
				if (cb_getResultObject_Ljava_lang_String_ == null)
					cb_getResultObject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetResultObject_Ljava_lang_String_);
				return cb_getResultObject_Ljava_lang_String_;
			}

			static IntPtr n_GetResultObject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResultObject (name));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getResultObject_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='getResultObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getResultObject", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetResultObject_Ljava_lang_String_Handler")]
			public virtual unsafe global::Java.Lang.Object GetResultObject (string name)
			{
				if (id_getResultObject_Ljava_lang_String_ == IntPtr.Zero)
					id_getResultObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResultObject", "(Ljava/lang/String;)Ljava/lang/Object;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResultObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultObject", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static Delegate cb_initializerNames;
#pragma warning disable 0169
			static Delegate GetInitializerNamesHandler ()
			{
				if (cb_initializerNames == null)
					cb_initializerNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_InitializerNames);
				return cb_initializerNames;
			}

			static IntPtr n_InitializerNames (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.InitializerNames ());
			}
#pragma warning restore 0169

			static IntPtr id_initializerNames;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='initializerNames' and count(parameter)=0]"
			[Register ("initializerNames", "()Ljava/util/Set;", "GetInitializerNamesHandler")]
			public virtual unsafe global::System.Collections.Generic.ICollection<string> InitializerNames ()
			{
				if (id_initializerNames == IntPtr.Zero)
					id_initializerNames = JNIEnv.GetMethodID (class_ref, "initializerNames", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initializerNames), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializerNames", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_isException_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetIsException_Ljava_lang_String_Handler ()
			{
				if (cb_isException_Ljava_lang_String_ == null)
					cb_isException_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsException_Ljava_lang_String_);
				return cb_isException_Ljava_lang_String_;
			}

			static bool n_IsException_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsException (name);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_isException_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer.MultiBackgroundInitializerResults']/method[@name='isException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("isException", "(Ljava/lang/String;)Z", "GetIsException_Ljava_lang_String_Handler")]
			public virtual unsafe bool IsException (string name)
			{
				if (id_isException_Ljava_lang_String_ == IntPtr.Zero)
					id_isException_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isException", "(Ljava/lang/String;)Z");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isException_Ljava_lang_String_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isException", "(Ljava/lang/String;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/MultiBackgroundInitializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiBackgroundInitializer); }
		}

		protected MultiBackgroundInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer']/constructor[@name='MultiBackgroundInitializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiBackgroundInitializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MultiBackgroundInitializer)) {
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

		static IntPtr id_ctor_Ljava_util_concurrent_ExecutorService_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer']/constructor[@name='MultiBackgroundInitializer' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ExecutorService']]"
		[Register (".ctor", "(Ljava/util/concurrent/ExecutorService;)V", "")]
		public unsafe MultiBackgroundInitializer (global::Java.Util.Concurrent.IExecutorService exec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exec);
				if (((object) this).GetType () != typeof (MultiBackgroundInitializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/concurrent/ExecutorService;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/concurrent/ExecutorService;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_concurrent_ExecutorService_ == IntPtr.Zero)
					id_ctor_Ljava_util_concurrent_ExecutorService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/concurrent/ExecutorService;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_concurrent_ExecutorService_, __args);
			} finally {
			}
		}

		static Delegate cb_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_;
#pragma warning disable 0169
		static Delegate GetAddInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_Handler ()
		{
			if (cb_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_ == null)
				cb_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AddInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_);
			return cb_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_;
		}

		static void n_AddInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_init)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var init = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer> (native_init, JniHandleOwnership.DoNotTransfer);
			__this.AddInitializer (name, init);
		}
#pragma warning restore 0169

		static IntPtr id_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer']/method[@name='addInitializer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.apache.commons.lang3.concurrent.BackgroundInitializer&lt;?&gt;']]"
		[Register ("addInitializer", "(Ljava/lang/String;Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;)V", "GetAddInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_Handler")]
		public virtual unsafe void AddInitializer (string name, global::Org.Apache.Commons.Lang3.Concurrent.BackgroundInitializer init)
		{
			if (id_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_ == IntPtr.Zero)
				id_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_ = JNIEnv.GetMethodID (class_ref, "addInitializer", "(Ljava/lang/String;Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;)V");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_name);
				__args [1] = new JValue (init);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addInitializer_Ljava_lang_String_Lorg_apache_commons_lang3_concurrent_BackgroundInitializer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addInitializer", "(Ljava/lang/String;Lorg/apache/commons/lang3/concurrent/BackgroundInitializer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Initialize);
			return cb_initialize;
		}

		static IntPtr n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Initialize ());
		}
#pragma warning restore 0169

		static IntPtr id_initialize;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='MultiBackgroundInitializer']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()Lorg/apache/commons/lang3/concurrent/MultiBackgroundInitializer$MultiBackgroundInitializerResults;", "GetInitializeHandler")]
		protected virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults Initialize ()
		{
			if (id_initialize == IntPtr.Zero)
				id_initialize = JNIEnv.GetMethodID (class_ref, "initialize", "()Lorg/apache/commons/lang3/concurrent/MultiBackgroundInitializer$MultiBackgroundInitializerResults;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initialize), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.MultiBackgroundInitializer.MultiBackgroundInitializerResults> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "()Lorg/apache/commons/lang3/concurrent/MultiBackgroundInitializer$MultiBackgroundInitializerResults;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
