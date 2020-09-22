using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Maybe {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeSwitchIfEmptySingle']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/maybe/MaybeSwitchIfEmptySingle", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class MaybeSwitchIfEmptySingle : global::IO.Reactivex.Single, global::IO.Reactivex.Internal.Fuseable.IHasUpstreamMaybeSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/maybe/MaybeSwitchIfEmptySingle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MaybeSwitchIfEmptySingle); }
		}

		internal MaybeSwitchIfEmptySingle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeSwitchIfEmptySingle']/constructor[@name='MaybeSwitchIfEmptySingle' and count(parameter)=2 and parameter[1][@type='io.reactivex.MaybeSource&lt;T&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/MaybeSource;Lio/reactivex/SingleSource;)V", "")]
		public unsafe MaybeSwitchIfEmptySingle (global::IO.Reactivex.IMaybeSource source, global::IO.Reactivex.ISingleSource other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (source);
				__args [1] = new JValue (other);
				if (((object) this).GetType () != typeof (MaybeSwitchIfEmptySingle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/MaybeSource;Lio/reactivex/SingleSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/MaybeSource;Lio/reactivex/SingleSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_SingleSource_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/MaybeSource;Lio/reactivex/SingleSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_SingleSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_MaybeSource_Lio_reactivex_SingleSource_, __args);
			} finally {
			}
		}

		static IntPtr id_source;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeSwitchIfEmptySingle']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/MaybeSource;", "")]
		public unsafe global::IO.Reactivex.IMaybeSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/MaybeSource;");
			try {
				return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.maybe']/class[@name='MaybeSwitchIfEmptySingle']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super T&gt;']]"
		[Register ("subscribeActual", "(Lio/reactivex/SingleObserver;)V", "")]
		protected override unsafe void SubscribeActual (global::IO.Reactivex.ISingleObserver observer)
		{
			if (id_subscribeActual_Lio_reactivex_SingleObserver_ == IntPtr.Zero)
				id_subscribeActual_Lio_reactivex_SingleObserver_ = JNIEnv.GetMethodID (class_ref, "subscribeActual", "(Lio/reactivex/SingleObserver;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (observer);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribeActual_Lio_reactivex_SingleObserver_, __args);
			} finally {
			}
		}

	}
}
