using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Operators.Single {

	// Metadata.xml XPath class reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleEquals']"
	[global::Android.Runtime.Register ("io/reactivex/internal/operators/single/SingleEquals", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class SingleEquals : global::IO.Reactivex.Single {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("io/reactivex/internal/operators/single/SingleEquals", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SingleEquals); }
		}

		internal SingleEquals (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleEquals']/constructor[@name='SingleEquals' and count(parameter)=2 and parameter[1][@type='io.reactivex.SingleSource&lt;? extends T&gt;'] and parameter[2][@type='io.reactivex.SingleSource&lt;? extends T&gt;']]"
		[Register (".ctor", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)V", "")]
		public unsafe SingleEquals (global::IO.Reactivex.ISingleSource first, global::IO.Reactivex.ISingleSource second)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (first);
				__args [1] = new JValue (second);
				if (((object) this).GetType () != typeof (SingleEquals)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)V", __args);
					return;
				}

				if (id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_ == IntPtr.Zero)
					id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lio/reactivex/SingleSource;Lio/reactivex/SingleSource;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lio_reactivex_SingleSource_Lio_reactivex_SingleSource_, __args);
			} finally {
			}
		}

		static IntPtr id_subscribeActual_Lio_reactivex_SingleObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.operators.single']/class[@name='SingleEquals']/method[@name='subscribeActual' and count(parameter)=1 and parameter[1][@type='io.reactivex.SingleObserver&lt;? super java.lang.Boolean&gt;']]"
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
