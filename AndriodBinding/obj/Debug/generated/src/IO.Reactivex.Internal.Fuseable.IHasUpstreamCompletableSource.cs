using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='HasUpstreamCompletableSource']"
	[Register ("io/reactivex/internal/fuseable/HasUpstreamCompletableSource", "", "IO.Reactivex.Internal.Fuseable.IHasUpstreamCompletableSourceInvoker")]
	public partial interface IHasUpstreamCompletableSource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='HasUpstreamCompletableSource']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/CompletableSource;", "GetSourceHandler:IO.Reactivex.Internal.Fuseable.IHasUpstreamCompletableSourceInvoker, AndriodBinding")]
		global::IO.Reactivex.ICompletableSource Source ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/HasUpstreamCompletableSource", DoNotGenerateAcw=true)]
	internal partial class IHasUpstreamCompletableSourceInvoker : global::Java.Lang.Object, IHasUpstreamCompletableSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/HasUpstreamCompletableSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHasUpstreamCompletableSourceInvoker); }
		}

		IntPtr class_ref;

		public static IHasUpstreamCompletableSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHasUpstreamCompletableSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.HasUpstreamCompletableSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHasUpstreamCompletableSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_source;
#pragma warning disable 0169
		static Delegate GetSourceHandler ()
		{
			if (cb_source == null)
				cb_source = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Source);
			return cb_source;
		}

		static IntPtr n_Source (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IHasUpstreamCompletableSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source ());
		}
#pragma warning restore 0169

		IntPtr id_source;
		public unsafe global::IO.Reactivex.ICompletableSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/CompletableSource;");
			return global::Java.Lang.Object.GetObject<global::IO.Reactivex.ICompletableSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
		}

	}

}
