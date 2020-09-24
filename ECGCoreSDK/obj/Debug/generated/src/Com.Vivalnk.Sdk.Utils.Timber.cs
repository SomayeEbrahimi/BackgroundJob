using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/Timber", DoNotGenerateAcw=true)]
	public sealed partial class Timber : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/field[@name='TREE_ARRAY_EMPTY']"
		[Register ("TREE_ARRAY_EMPTY")]
		public static IList<Com.Vivalnk.Sdk.Utils.Timber.Tree> TreeArrayEmpty {
			get {
				const string __id = "TREE_ARRAY_EMPTY.[Lcom/vivalnk/sdk/utils/Timber$Tree;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Utils.Timber.Tree>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/field[@name='TREE_OF_SOULS']"
		[Register ("TREE_OF_SOULS")]
		public static global::Com.Vivalnk.Sdk.Utils.Timber.Tree TreeOfSouls {
			get {
				const string __id = "TREE_OF_SOULS.Lcom/vivalnk/sdk/utils/Timber$Tree;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/field[@name='forestAsArray']"
		[Register ("forestAsArray")]
		public static IList<Com.Vivalnk.Sdk.Utils.Timber.Tree> ForestAsArray {
			get {
				const string __id = "forestAsArray.[Lcom/vivalnk/sdk/utils/Timber$Tree;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Utils.Timber.Tree>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "forestAsArray.[Lcom/vivalnk/sdk/utils/Timber$Tree;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Vivalnk.Sdk.Utils.Timber.Tree>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/Timber$DebugTree", DoNotGenerateAcw=true)]
		public partial class DebugTree : global::Com.Vivalnk.Sdk.Utils.Timber.Tree {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/field[@name='ANONYMOUS_CLASS']"
			[Register ("ANONYMOUS_CLASS")]
			public static global::Java.Util.Regex.Pattern AnonymousClass {
				get {
					const string __id = "ANONYMOUS_CLASS.Ljava/util/regex/Pattern;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/field[@name='CALL_STACK_INDEX']"
			[Register ("CALL_STACK_INDEX")]
			public const int CallStackIndex = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/field[@name='MAX_LOG_LENGTH']"
			[Register ("MAX_LOG_LENGTH")]
			public const int MaxLogLength = (int) 4000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/field[@name='MAX_TAG_LENGTH']"
			[Register ("MAX_TAG_LENGTH")]
			public const int MaxTagLength = (int) 23;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/Timber$DebugTree", typeof (DebugTree));
			internal static new IntPtr class_ref {
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

			protected DebugTree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/constructor[@name='Timber.DebugTree' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DebugTree ()
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

			public override unsafe string Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getTag.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_createStackElementTag_Ljava_lang_StackTraceElement_;
#pragma warning disable 0169
			static Delegate GetCreateStackElementTag_Ljava_lang_StackTraceElement_Handler ()
			{
				if (cb_createStackElementTag_Ljava_lang_StackTraceElement_ == null)
					cb_createStackElementTag_Ljava_lang_StackTraceElement_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CreateStackElementTag_Ljava_lang_StackTraceElement_);
				return cb_createStackElementTag_Ljava_lang_StackTraceElement_;
			}

			static IntPtr n_CreateStackElementTag_Ljava_lang_StackTraceElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.DebugTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.StackTraceElement> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.CreateStackElementTag (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/method[@name='createStackElementTag' and count(parameter)=1 and parameter[1][@type='java.lang.StackTraceElement']]"
			[Register ("createStackElementTag", "(Ljava/lang/StackTraceElement;)Ljava/lang/String;", "GetCreateStackElementTag_Ljava_lang_StackTraceElement_Handler")]
			public virtual unsafe string CreateStackElementTag (global::Java.Lang.StackTraceElement p0)
			{
				const string __id = "createStackElementTag.(Ljava/lang/StackTraceElement;)Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
			{
				if (cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
					cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_V) n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
				return cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
			}

			static void n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.DebugTree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.Log (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.DebugTree']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
			[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
			public override unsafe void Log (int p0, string p1, string p2, global::Java.Lang.Throwable p3)
			{
				const string __id = "log.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p3).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']"
		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/Timber$Tree", DoNotGenerateAcw=true)]
		public abstract partial class Tree : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/field[@name='explicitTag']"
			[Register ("explicitTag")]
			public global::Java.Lang.ThreadLocal ExplicitTag {
				get {
					const string __id = "explicitTag.Ljava/lang/ThreadLocal;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ThreadLocal> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "explicitTag.Ljava/lang/ThreadLocal;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/Timber$Tree", typeof (Tree));
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

			protected Tree (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/constructor[@name='Timber.Tree' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Tree ()
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

			static Delegate cb_getTag;
#pragma warning disable 0169
			static Delegate GetGetTagHandler ()
			{
				if (cb_getTag == null)
					cb_getTag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTag);
				return cb_getTag;
			}

			static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Tag);
			}
#pragma warning restore 0169

			public virtual unsafe string Tag {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='getTag' and count(parameter)=0]"
				[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
				get {
					const string __id = "getTag.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_d_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_d_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_D_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_d_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_D_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.D (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void D (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "d.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_d_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_Throwable_Handler ()
			{
				if (cb_d_Ljava_lang_Throwable_ == null)
					cb_d_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_D_Ljava_lang_Throwable_);
				return cb_d_Ljava_lang_Throwable_;
			}

			static void n_D_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.D (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("d", "(Ljava/lang/Throwable;)V", "GetD_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void D (global::Java.Lang.Throwable p0)
			{
				const string __id = "d.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_D_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_d_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_D_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.D (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void D (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "d.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_e_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_e_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_e_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_E_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_e_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_E_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.E (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void E (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "e.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_e_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_Throwable_Handler ()
			{
				if (cb_e_Ljava_lang_Throwable_ == null)
					cb_e_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_E_Ljava_lang_Throwable_);
				return cb_e_Ljava_lang_Throwable_;
			}

			static void n_E_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.E (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("e", "(Ljava/lang/Throwable;)V", "GetE_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void E (global::Java.Lang.Throwable p0)
			{
				const string __id = "e.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_E_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_e_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_E_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.E (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void E (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static IntPtr n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.NewString (__this.FormatMessage (p0, p1));
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='formatMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
			[Register ("formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe string FormatMessage (string p0, global::Java.Lang.Object[] p1)
			{
				const string __id = "formatMessage.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_i_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetI_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_i_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_i_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_I_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_i_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_I_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.I (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("i", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetI_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void I (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "i.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_i_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetI_Ljava_lang_Throwable_Handler ()
			{
				if (cb_i_Ljava_lang_Throwable_ == null)
					cb_i_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_I_Ljava_lang_Throwable_);
				return cb_i_Ljava_lang_Throwable_;
			}

			static void n_I_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.I (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("i", "(Ljava/lang/Throwable;)V", "GetI_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void I (global::Java.Lang.Throwable p0)
			{
				const string __id = "i.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetI_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_I_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_i_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_I_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.I (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("i", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetI_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void I (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "i.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_isLoggable_I;
#pragma warning disable 0169
			static Delegate GetIsLoggable_IHandler ()
			{
				if (cb_isLoggable_I == null)
					cb_isLoggable_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsLoggable_I);
				return cb_isLoggable_I;
			}

			static bool n_IsLoggable_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsLoggable (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='isLoggable' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isLoggable", "(I)Z", "GetIsLoggable_IHandler")]
			public virtual unsafe bool IsLoggable (int p0)
			{
				const string __id = "isLoggable.(I)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_isLoggable_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetIsLoggable_Ljava_lang_String_IHandler ()
			{
				if (cb_isLoggable_Ljava_lang_String_I == null)
					cb_isLoggable_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_IsLoggable_Ljava_lang_String_I);
				return cb_isLoggable_Ljava_lang_String_I;
			}

			static bool n_IsLoggable_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsLoggable (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='isLoggable' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("isLoggable", "(Ljava/lang/String;I)Z", "GetIsLoggable_Ljava_lang_String_IHandler")]
			public virtual unsafe bool IsLoggable (string p0, int p1)
			{
				const string __id = "isLoggable.(Ljava/lang/String;I)Z";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_log_ILjava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetLog_ILjava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_log_ILjava_lang_String_arrayLjava_lang_Object_ == null)
					cb_log_ILjava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_Log_ILjava_lang_String_arrayLjava_lang_Object_);
				return cb_log_ILjava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_Log_ILjava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.Log (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("log", "(ILjava/lang/String;[Ljava/lang/Object;)V", "GetLog_ILjava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void Log (int p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "log.(ILjava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
			{
				if (cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
					cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_V) n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
				return cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
			}

			static void n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.Log (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
			[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
			public abstract void Log (int p0, string p1, string p2, global::Java.Lang.Throwable p3);

			static Delegate cb_log_ILjava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetLog_ILjava_lang_Throwable_Handler ()
			{
				if (cb_log_ILjava_lang_Throwable_ == null)
					cb_log_ILjava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Log_ILjava_lang_Throwable_);
				return cb_log_ILjava_lang_Throwable_;
			}

			static void n_Log_ILjava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Log (p0, p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='log' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable']]"
			[Register ("log", "(ILjava/lang/Throwable;)V", "GetLog_ILjava_lang_Throwable_Handler")]
			public virtual unsafe void Log (int p0, global::Java.Lang.Throwable p1)
			{
				const string __id = "log.(ILjava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetLog_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLL_V) n_Log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_Log_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				var p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.Log (p0, p1, p2, p3);
				if (p3 != null)
					JNIEnv.CopyArray (p3, native_p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
			[Register ("log", "(ILjava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetLog_ILjava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void Log (int p0, global::Java.Lang.Throwable p1, string p2, params global::Java.Lang.Object[] p3)
			{
				const string __id = "log.(ILjava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue (native_p3);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
				}
			}

			static Delegate cb_v_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetV_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_v_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_v_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_V_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_v_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_V_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.V (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("v", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetV_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void V (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "v.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_v_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetV_Ljava_lang_Throwable_Handler ()
			{
				if (cb_v_Ljava_lang_Throwable_ == null)
					cb_v_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_V_Ljava_lang_Throwable_);
				return cb_v_Ljava_lang_Throwable_;
			}

			static void n_V_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.V (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("v", "(Ljava/lang/Throwable;)V", "GetV_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void V (global::Java.Lang.Throwable p0)
			{
				const string __id = "v.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetV_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_V_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_v_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_V_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.V (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("v", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetV_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void V (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "v.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_w_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetW_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_w_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_w_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_W_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_w_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_W_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.W (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("w", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetW_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void W (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "w.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_w_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetW_Ljava_lang_Throwable_Handler ()
			{
				if (cb_w_Ljava_lang_Throwable_ == null)
					cb_w_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_W_Ljava_lang_Throwable_);
				return cb_w_Ljava_lang_Throwable_;
			}

			static void n_W_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.W (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("w", "(Ljava/lang/Throwable;)V", "GetW_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void W (global::Java.Lang.Throwable p0)
			{
				const string __id = "w.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetW_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_W_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_w_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_W_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.W (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("w", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetW_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void W (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "w.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

			static Delegate cb_wtf_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWtf_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_wtf_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_wtf_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Wtf_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_wtf_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_Wtf_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.Wtf (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
			[Register ("wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V", "GetWtf_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void Wtf (string p0, params global::Java.Lang.Object[] p1)
			{
				const string __id = "wtf.(Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (native_p1);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_wtf_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetWtf_Ljava_lang_Throwable_Handler ()
			{
				if (cb_wtf_Ljava_lang_Throwable_ == null)
					cb_wtf_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Wtf_Ljava_lang_Throwable_);
				return cb_wtf_Ljava_lang_Throwable_;
			}

			static void n_Wtf_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Wtf (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("wtf", "(Ljava/lang/Throwable;)V", "GetWtf_Ljava_lang_Throwable_Handler")]
			public virtual unsafe void Wtf (global::Java.Lang.Throwable p0)
			{
				const string __id = "wtf.(Ljava/lang/Throwable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetWtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_Wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_Wtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.Wtf (p0, p1, p2);
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetWtf_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
			public virtual unsafe void Wtf (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
			{
				const string __id = "wtf.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		[global::Android.Runtime.Register ("com/vivalnk/sdk/utils/Timber$Tree", DoNotGenerateAcw=true)]
		internal partial class TreeInvoker : Tree {

			public TreeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/Timber$Tree", typeof (TreeInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber.Tree']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Throwable']]"
			[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
			public override unsafe void Log (int p0, string p1, string p2, global::Java.Lang.Throwable p3)
			{
				const string __id = "log.(ILjava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V";
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p3).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/utils/Timber", typeof (Timber));
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

		internal Timber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/constructor[@name='Timber' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Timber ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='asTree' and count(parameter)=0]"
		[Register ("asTree", "()Lcom/vivalnk/sdk/utils/Timber$Tree;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.Timber.Tree AsTree ()
		{
			const string __id = "asTree.()Lcom/vivalnk/sdk/utils/Timber$Tree;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "d.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void D (global::Java.Lang.Throwable p0)
		{
			const string __id = "d.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "d.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "e.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable p0)
		{
			const string __id = "e.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "e.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='forest' and count(parameter)=0]"
		[Register ("forest", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> Forest ()
		{
			const string __id = "forest.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Utils.Timber.Tree>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "i.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void I (global::Java.Lang.Throwable p0)
		{
			const string __id = "i.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "i.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("log", "(ILjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Log (int p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "log.(ILjava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='log' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/Throwable;)V", "")]
		public static unsafe void Log (int p0, global::Java.Lang.Throwable p1)
		{
			const string __id = "log.(ILjava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("log", "(ILjava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Log (int p0, global::Java.Lang.Throwable p1, string p2, params global::Java.Lang.Object[] p3)
		{
			const string __id = "log.(ILjava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='plant' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.utils.Timber.Tree']]"
		[Register ("plant", "(Lcom/vivalnk/sdk/utils/Timber$Tree;)V", "")]
		public static unsafe void Plant (global::Com.Vivalnk.Sdk.Utils.Timber.Tree p0)
		{
			const string __id = "plant.(Lcom/vivalnk/sdk/utils/Timber$Tree;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='plant' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.utils.Timber.Tree...']]"
		[Register ("plant", "([Lcom/vivalnk/sdk/utils/Timber$Tree;)V", "")]
		public static unsafe void Plant (params global::Com.Vivalnk.Sdk.Utils.Timber.Tree[] p0)
		{
			const string __id = "plant.([Lcom/vivalnk/sdk/utils/Timber$Tree;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tag", "(Ljava/lang/String;)Lcom/vivalnk/sdk/utils/Timber$Tree;", "")]
		public static unsafe global::Com.Vivalnk.Sdk.Utils.Timber.Tree Tag (string p0)
		{
			const string __id = "tag.(Ljava/lang/String;)Lcom/vivalnk/sdk/utils/Timber$Tree;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Utils.Timber.Tree> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='treeCount' and count(parameter)=0]"
		[Register ("treeCount", "()I", "")]
		public static unsafe int TreeCount ()
		{
			const string __id = "treeCount.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='uproot' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.utils.Timber.Tree']]"
		[Register ("uproot", "(Lcom/vivalnk/sdk/utils/Timber$Tree;)V", "")]
		public static unsafe void Uproot (global::Com.Vivalnk.Sdk.Utils.Timber.Tree p0)
		{
			const string __id = "uproot.(Lcom/vivalnk/sdk/utils/Timber$Tree;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='uprootAll' and count(parameter)=0]"
		[Register ("uprootAll", "()V", "")]
		public static unsafe void UprootAll ()
		{
			const string __id = "uprootAll.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "v.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void V (global::Java.Lang.Throwable p0)
		{
			const string __id = "v.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("v", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void V (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "v.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "w.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void W (global::Java.Lang.Throwable p0)
		{
			const string __id = "w.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "w.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='wtf' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "wtf.(Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='wtf' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("wtf", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Throwable p0)
		{
			const string __id = "wtf.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.utils']/class[@name='Timber']/method[@name='wtf' and count(parameter)=3 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("wtf", "(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void Wtf (global::Java.Lang.Throwable p0, string p1, params global::Java.Lang.Object[] p2)
		{
			const string __id = "wtf.(Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
