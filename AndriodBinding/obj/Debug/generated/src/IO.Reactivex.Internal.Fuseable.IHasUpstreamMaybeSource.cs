using System;
using System.Collections.Generic;
using Android.Runtime;

namespace IO.Reactivex.Internal.Fuseable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='HasUpstreamMaybeSource']"
	[Register ("io/reactivex/internal/fuseable/HasUpstreamMaybeSource", "", "IO.Reactivex.Internal.Fuseable.IHasUpstreamMaybeSourceInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IHasUpstreamMaybeSource : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='io.reactivex.internal.fuseable']/interface[@name='HasUpstreamMaybeSource']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()Lio/reactivex/MaybeSource;", "GetSourceHandler:IO.Reactivex.Internal.Fuseable.IHasUpstreamMaybeSourceInvoker, AndriodBinding")]
		global::IO.Reactivex.IMaybeSource Source ();

	}

	[global::Android.Runtime.Register ("io/reactivex/internal/fuseable/HasUpstreamMaybeSource", DoNotGenerateAcw=true)]
	internal partial class IHasUpstreamMaybeSourceInvoker : global::Java.Lang.Object, IHasUpstreamMaybeSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("io/reactivex/internal/fuseable/HasUpstreamMaybeSource");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHasUpstreamMaybeSourceInvoker); }
		}

		IntPtr class_ref;

		public static IHasUpstreamMaybeSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHasUpstreamMaybeSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "io.reactivex.internal.fuseable.HasUpstreamMaybeSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHasUpstreamMaybeSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::IO.Reactivex.Internal.Fuseable.IHasUpstreamMaybeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source ());
		}
#pragma warning restore 0169

		IntPtr id_source;
		public unsafe global::IO.Reactivex.IMaybeSource Source ()
		{
			if (id_source == IntPtr.Zero)
				id_source = JNIEnv.GetMethodID (class_ref, "source", "()Lio/reactivex/MaybeSource;");
			return global::Java.Lang.Object.GetObject<global::IO.Reactivex.IMaybeSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_source), JniHandleOwnership.TransferLocalRef);
		}

	}

}
