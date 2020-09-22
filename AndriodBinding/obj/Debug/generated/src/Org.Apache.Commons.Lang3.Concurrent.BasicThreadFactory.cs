using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Concurrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/BasicThreadFactory", DoNotGenerateAcw=true)]
	public partial class BasicThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']"
		[global::Android.Runtime.Register ("org/apache/commons/lang3/concurrent/BasicThreadFactory$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object, global::Org.Apache.Commons.Lang3.Builder.IBuilder {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/BasicThreadFactory$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/constructor[@name='BasicThreadFactory.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Builder)) {
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lorg/apache/commons/lang3/concurrent/BasicThreadFactory;", "GetBuildHandler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lorg/apache/commons/lang3/concurrent/BasicThreadFactory;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lorg/apache/commons/lang3/concurrent/BasicThreadFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_daemon_Z;
#pragma warning disable 0169
			static Delegate GetDaemon_ZHandler ()
			{
				if (cb_daemon_Z == null)
					cb_daemon_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_Daemon_Z);
				return cb_daemon_Z;
			}

			static IntPtr n_Daemon_Z (IntPtr jnienv, IntPtr native__this, bool daemon)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Daemon (daemon));
			}
#pragma warning restore 0169

			static IntPtr id_daemon_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='daemon' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("daemon", "(Z)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;", "GetDaemon_ZHandler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder Daemon (bool daemon)
			{
				if (id_daemon_Z == IntPtr.Zero)
					id_daemon_Z = JNIEnv.GetMethodID (class_ref, "daemon", "(Z)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (daemon);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_daemon_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "daemon", "(Z)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_namingPattern_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNamingPattern_Ljava_lang_String_Handler ()
			{
				if (cb_namingPattern_Ljava_lang_String_ == null)
					cb_namingPattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NamingPattern_Ljava_lang_String_);
				return cb_namingPattern_Ljava_lang_String_;
			}

			static IntPtr n_NamingPattern_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pattern)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var pattern = JNIEnv.GetString (native_pattern, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NamingPattern (pattern));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_namingPattern_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='namingPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("namingPattern", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;", "GetNamingPattern_Ljava_lang_String_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder NamingPattern (string pattern)
			{
				if (id_namingPattern_Ljava_lang_String_ == IntPtr.Zero)
					id_namingPattern_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "namingPattern", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;");
				IntPtr native_pattern = JNIEnv.NewString (pattern);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_pattern);

					global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_namingPattern_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "namingPattern", "(Ljava/lang/String;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_pattern);
				}
			}

			static Delegate cb_priority_I;
#pragma warning disable 0169
			static Delegate GetPriority_IHandler ()
			{
				if (cb_priority_I == null)
					cb_priority_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Priority_I);
				return cb_priority_I;
			}

			static IntPtr n_Priority_I (IntPtr jnienv, IntPtr native__this, int priority)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Priority (priority));
			}
#pragma warning restore 0169

			static IntPtr id_priority_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='priority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("priority", "(I)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;", "GetPriority_IHandler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder Priority (int priority)
			{
				if (id_priority_I == IntPtr.Zero)
					id_priority_I = JNIEnv.GetMethodID (class_ref, "priority", "(I)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (priority);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_priority_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "priority", "(I)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_reset;
#pragma warning disable 0169
			static Delegate GetResetHandler ()
			{
				if (cb_reset == null)
					cb_reset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reset);
				return cb_reset;
			}

			static void n_Reset (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Reset ();
			}
#pragma warning restore 0169

			static IntPtr id_reset;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='reset' and count(parameter)=0]"
			[Register ("reset", "()V", "GetResetHandler")]
			public virtual unsafe void Reset ()
			{
				if (id_reset == IntPtr.Zero)
					id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
				} finally {
				}
			}

			static Delegate cb_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
#pragma warning disable 0169
			static Delegate GetUncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_Handler ()
			{
				if (cb_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ == null)
					cb_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_UncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_);
				return cb_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
			}

			static IntPtr n_UncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var handler = (global::Java.Lang.Thread.IUncaughtExceptionHandler)global::Java.Lang.Object.GetObject<global::Java.Lang.Thread.IUncaughtExceptionHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UncaughtExceptionHandler (handler));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='uncaughtExceptionHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Thread.UncaughtExceptionHandler']]"
			[Register ("uncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;", "GetUncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder UncaughtExceptionHandler (global::Java.Lang.Thread.IUncaughtExceptionHandler handler)
			{
				if (id_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ == IntPtr.Zero)
					id_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_ = JNIEnv.GetMethodID (class_ref, "uncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (handler);

					global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_uncaughtExceptionHandler_Ljava_lang_Thread_UncaughtExceptionHandler_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uncaughtExceptionHandler", "(Ljava/lang/Thread$UncaughtExceptionHandler;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_wrappedFactory_Ljava_util_concurrent_ThreadFactory_;
#pragma warning disable 0169
			static Delegate GetWrappedFactory_Ljava_util_concurrent_ThreadFactory_Handler ()
			{
				if (cb_wrappedFactory_Ljava_util_concurrent_ThreadFactory_ == null)
					cb_wrappedFactory_Ljava_util_concurrent_ThreadFactory_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WrappedFactory_Ljava_util_concurrent_ThreadFactory_);
				return cb_wrappedFactory_Ljava_util_concurrent_ThreadFactory_;
			}

			static IntPtr n_WrappedFactory_Ljava_util_concurrent_ThreadFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var factory = (global::Java.Util.Concurrent.IThreadFactory)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WrappedFactory (factory));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_wrappedFactory_Ljava_util_concurrent_ThreadFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory.Builder']/method[@name='wrappedFactory' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.ThreadFactory']]"
			[Register ("wrappedFactory", "(Ljava/util/concurrent/ThreadFactory;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;", "GetWrappedFactory_Ljava_util_concurrent_ThreadFactory_Handler")]
			public virtual unsafe global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder WrappedFactory (global::Java.Util.Concurrent.IThreadFactory factory)
			{
				if (id_wrappedFactory_Ljava_util_concurrent_ThreadFactory_ == IntPtr.Zero)
					id_wrappedFactory_Ljava_util_concurrent_ThreadFactory_ = JNIEnv.GetMethodID (class_ref, "wrappedFactory", "(Ljava/util/concurrent/ThreadFactory;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (factory);

					global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_wrappedFactory_Ljava_util_concurrent_ThreadFactory_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrappedFactory", "(Ljava/util/concurrent/ThreadFactory;)Lorg/apache/commons/lang3/concurrent/BasicThreadFactory$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			// This method is explicitly implemented as a member of an instantiated Org.Apache.Commons.Lang3.Builder.IBuilder
			global::Java.Lang.Object global::Org.Apache.Commons.Lang3.Builder.IBuilder.Build ()
			{
				return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Build ());
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/concurrent/BasicThreadFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasicThreadFactory); }
		}

		protected BasicThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDaemonFlag;
		public unsafe global::Java.Lang.Boolean DaemonFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getDaemonFlag' and count(parameter)=0]"
			[Register ("getDaemonFlag", "()Ljava/lang/Boolean;", "")]
			get {
				if (id_getDaemonFlag == IntPtr.Zero)
					id_getDaemonFlag = JNIEnv.GetMethodID (class_ref, "getDaemonFlag", "()Ljava/lang/Boolean;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDaemonFlag), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNamingPattern;
		public unsafe string NamingPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getNamingPattern' and count(parameter)=0]"
			[Register ("getNamingPattern", "()Ljava/lang/String;", "")]
			get {
				if (id_getNamingPattern == IntPtr.Zero)
					id_getNamingPattern = JNIEnv.GetMethodID (class_ref, "getNamingPattern", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNamingPattern), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPriority;
		public unsafe global::Java.Lang.Integer Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()Ljava/lang/Integer;", "")]
			get {
				if (id_getPriority == IntPtr.Zero)
					id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPriority), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThreadCount;
#pragma warning disable 0169
		static Delegate GetGetThreadCountHandler ()
		{
			if (cb_getThreadCount == null)
				cb_getThreadCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetThreadCount);
			return cb_getThreadCount;
		}

		static long n_GetThreadCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadCount;
		}
#pragma warning restore 0169

		static IntPtr id_getThreadCount;
		public virtual unsafe long ThreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getThreadCount' and count(parameter)=0]"
			[Register ("getThreadCount", "()J", "GetGetThreadCountHandler")]
			get {
				if (id_getThreadCount == IntPtr.Zero)
					id_getThreadCount = JNIEnv.GetMethodID (class_ref, "getThreadCount", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getThreadCount);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreadCount", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_getUncaughtExceptionHandler;
		public unsafe global::Java.Lang.Thread.IUncaughtExceptionHandler UncaughtExceptionHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getUncaughtExceptionHandler' and count(parameter)=0]"
			[Register ("getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;", "")]
			get {
				if (id_getUncaughtExceptionHandler == IntPtr.Zero)
					id_getUncaughtExceptionHandler = JNIEnv.GetMethodID (class_ref, "getUncaughtExceptionHandler", "()Ljava/lang/Thread$UncaughtExceptionHandler;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread.IUncaughtExceptionHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUncaughtExceptionHandler), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getWrappedFactory;
		public unsafe global::Java.Util.Concurrent.IThreadFactory WrappedFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='getWrappedFactory' and count(parameter)=0]"
			[Register ("getWrappedFactory", "()Ljava/util/concurrent/ThreadFactory;", "")]
			get {
				if (id_getWrappedFactory == IntPtr.Zero)
					id_getWrappedFactory = JNIEnv.GetMethodID (class_ref, "getWrappedFactory", "()Ljava/util/concurrent/ThreadFactory;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IThreadFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWrappedFactory), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
		{
			if (cb_newThread_Ljava_lang_Runnable_ == null)
				cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewThread_Ljava_lang_Runnable_);
			return cb_newThread_Ljava_lang_Runnable_;
		}

		static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Concurrent.BasicThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (runnable));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.concurrent']/class[@name='BasicThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable runnable)
		{
			if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);

				global::Java.Lang.Thread __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newThread_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
