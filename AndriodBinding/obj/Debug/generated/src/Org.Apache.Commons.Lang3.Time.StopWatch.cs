using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Apache.Commons.Lang3.Time {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']"
	[global::Android.Runtime.Register ("org/apache/commons/lang3/time/StopWatch", DoNotGenerateAcw=true)]
	public partial class StopWatch : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/apache/commons/lang3/time/StopWatch", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StopWatch); }
		}

		protected StopWatch (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/constructor[@name='StopWatch' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StopWatch ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StopWatch)) {
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

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		static IntPtr id_isStarted;
		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStarted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStopped;
#pragma warning disable 0169
		static Delegate GetIsStoppedHandler ()
		{
			if (cb_isStopped == null)
				cb_isStopped = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStopped);
			return cb_isStopped;
		}

		static bool n_IsStopped (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStopped;
		}
#pragma warning restore 0169

		static IntPtr id_isStopped;
		public virtual unsafe bool IsStopped {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='isStopped' and count(parameter)=0]"
			[Register ("isStopped", "()Z", "GetIsStoppedHandler")]
			get {
				if (id_isStopped == IntPtr.Zero)
					id_isStopped = JNIEnv.GetMethodID (class_ref, "isStopped", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStopped);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStopped", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSuspended;
#pragma warning disable 0169
		static Delegate GetIsSuspendedHandler ()
		{
			if (cb_isSuspended == null)
				cb_isSuspended = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuspended);
			return cb_isSuspended;
		}

		static bool n_IsSuspended (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuspended;
		}
#pragma warning restore 0169

		static IntPtr id_isSuspended;
		public virtual unsafe bool IsSuspended {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='isSuspended' and count(parameter)=0]"
			[Register ("isSuspended", "()Z", "GetIsSuspendedHandler")]
			get {
				if (id_isSuspended == IntPtr.Zero)
					id_isSuspended = JNIEnv.GetMethodID (class_ref, "isSuspended", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuspended);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuspended", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNanoTime;
#pragma warning disable 0169
		static Delegate GetGetNanoTimeHandler ()
		{
			if (cb_getNanoTime == null)
				cb_getNanoTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNanoTime);
			return cb_getNanoTime;
		}

		static long n_GetNanoTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NanoTime;
		}
#pragma warning restore 0169

		static IntPtr id_getNanoTime;
		public virtual unsafe long NanoTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getNanoTime' and count(parameter)=0]"
			[Register ("getNanoTime", "()J", "GetGetNanoTimeHandler")]
			get {
				if (id_getNanoTime == IntPtr.Zero)
					id_getNanoTime = JNIEnv.GetMethodID (class_ref, "getNanoTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNanoTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNanoTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSplitNanoTime;
#pragma warning disable 0169
		static Delegate GetGetSplitNanoTimeHandler ()
		{
			if (cb_getSplitNanoTime == null)
				cb_getSplitNanoTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSplitNanoTime);
			return cb_getSplitNanoTime;
		}

		static long n_GetSplitNanoTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SplitNanoTime;
		}
#pragma warning restore 0169

		static IntPtr id_getSplitNanoTime;
		public virtual unsafe long SplitNanoTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getSplitNanoTime' and count(parameter)=0]"
			[Register ("getSplitNanoTime", "()J", "GetGetSplitNanoTimeHandler")]
			get {
				if (id_getSplitNanoTime == IntPtr.Zero)
					id_getSplitNanoTime = JNIEnv.GetMethodID (class_ref, "getSplitNanoTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSplitNanoTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSplitNanoTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getSplitTime;
#pragma warning disable 0169
		static Delegate GetGetSplitTimeHandler ()
		{
			if (cb_getSplitTime == null)
				cb_getSplitTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetSplitTime);
			return cb_getSplitTime;
		}

		static long n_GetSplitTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SplitTime;
		}
#pragma warning restore 0169

		static IntPtr id_getSplitTime;
		public virtual unsafe long SplitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getSplitTime' and count(parameter)=0]"
			[Register ("getSplitTime", "()J", "GetGetSplitTimeHandler")]
			get {
				if (id_getSplitTime == IntPtr.Zero)
					id_getSplitTime = JNIEnv.GetMethodID (class_ref, "getSplitTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSplitTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSplitTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTime;
		public virtual unsafe long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetTime);
			return cb_getTime;
		}

		static long n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Time;
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		public virtual unsafe long Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()J", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_createStarted;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='createStarted' and count(parameter)=0]"
		[Register ("createStarted", "()Lorg/apache/commons/lang3/time/StopWatch;", "")]
		public static unsafe global::Org.Apache.Commons.Lang3.Time.StopWatch CreateStarted ()
		{
			if (id_createStarted == IntPtr.Zero)
				id_createStarted = JNIEnv.GetStaticMethodID (class_ref, "createStarted", "()Lorg/apache/commons/lang3/time/StopWatch;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createStarted), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTime_Ljava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGetTime_Ljava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_getTime_Ljava_util_concurrent_TimeUnit_ == null)
				cb_getTime_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetTime_Ljava_util_concurrent_TimeUnit_);
			return cb_getTime_Ljava_util_concurrent_TimeUnit_;
		}

		static long n_GetTime_Ljava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_timeUnit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var timeUnit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_timeUnit, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetTime (timeUnit);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTime_Ljava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='getTime' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("getTime", "(Ljava/util/concurrent/TimeUnit;)J", "GetGetTime_Ljava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe long GetTime (global::Java.Util.Concurrent.TimeUnit timeUnit)
		{
			if (id_getTime_Ljava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_getTime_Ljava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID (class_ref, "getTime", "(Ljava/util/concurrent/TimeUnit;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeUnit);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTime_Ljava_util_concurrent_TimeUnit_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "(Ljava/util/concurrent/TimeUnit;)J"), __args);
				return __ret;
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='reset' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_split;
#pragma warning disable 0169
		static Delegate GetSplitHandler ()
		{
			if (cb_split == null)
				cb_split = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Split);
			return cb_split;
		}

		static void n_Split (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Split ();
		}
#pragma warning restore 0169

		static IntPtr id_split;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='split' and count(parameter)=0]"
		[Register ("split", "()V", "GetSplitHandler")]
		public virtual unsafe void Split ()
		{
			if (id_split == IntPtr.Zero)
				id_split = JNIEnv.GetMethodID (class_ref, "split", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_split);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "split", "()V"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
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
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Suspend ();
		}
#pragma warning restore 0169

		static IntPtr id_suspend;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='suspend' and count(parameter)=0]"
		[Register ("suspend", "()V", "GetSuspendHandler")]
		public virtual unsafe void Suspend ()
		{
			if (id_suspend == IntPtr.Zero)
				id_suspend = JNIEnv.GetMethodID (class_ref, "suspend", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_suspend);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "suspend", "()V"));
			} finally {
			}
		}

		static Delegate cb_toSplitString;
#pragma warning disable 0169
		static Delegate GetToSplitStringHandler ()
		{
			if (cb_toSplitString == null)
				cb_toSplitString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToSplitString);
			return cb_toSplitString;
		}

		static IntPtr n_ToSplitString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToSplitString ());
		}
#pragma warning restore 0169

		static IntPtr id_toSplitString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='toSplitString' and count(parameter)=0]"
		[Register ("toSplitString", "()Ljava/lang/String;", "GetToSplitStringHandler")]
		public virtual unsafe string ToSplitString ()
		{
			if (id_toSplitString == IntPtr.Zero)
				id_toSplitString = JNIEnv.GetMethodID (class_ref, "toSplitString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toSplitString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toSplitString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unsplit;
#pragma warning disable 0169
		static Delegate GetUnsplitHandler ()
		{
			if (cb_unsplit == null)
				cb_unsplit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unsplit);
			return cb_unsplit;
		}

		static void n_Unsplit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Apache.Commons.Lang3.Time.StopWatch> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unsplit ();
		}
#pragma warning restore 0169

		static IntPtr id_unsplit;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.apache.commons.lang3.time']/class[@name='StopWatch']/method[@name='unsplit' and count(parameter)=0]"
		[Register ("unsplit", "()V", "GetUnsplitHandler")]
		public virtual unsafe void Unsplit ()
		{
			if (id_unsplit == IntPtr.Zero)
				id_unsplit = JNIEnv.GetMethodID (class_ref, "unsplit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsplit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsplit", "()V"));
			} finally {
			}
		}

	}
}
