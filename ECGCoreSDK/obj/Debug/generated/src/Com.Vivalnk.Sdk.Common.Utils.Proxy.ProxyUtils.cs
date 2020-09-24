using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Common.Utils.Proxy {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/common/utils/proxy/ProxyUtils", DoNotGenerateAcw=true)]
	public partial class ProxyUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/common/utils/proxy/ProxyUtils", typeof (ProxyUtils));
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

		protected ProxyUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/constructor[@name='ProxyUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProxyUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getProxy", "(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			const string __id = "getProxy.(Ljava/lang/Object;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			const string __id = "getProxy.(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [2] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef, bool postUI)
		{
			const string __id = "getProxy.(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [2] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				__args [3] = new JniArgumentValue (weakRef);
				__args [4] = new JniArgumentValue (postUI);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getProxy' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("getProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetProxy (global::Java.Lang.Object @object, global::Java.Lang.Class[] intfs, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor, bool weakRef, bool postUI)
		{
			const string __id = "getProxy.(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;ZZ)Ljava/lang/Object;";
			IntPtr native_intfs = JNIEnv.NewArray (intfs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue (native_intfs);
				__args [2] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				__args [3] = new JniArgumentValue (weakRef);
				__args [4] = new JniArgumentValue (postUI);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (intfs != null) {
					JNIEnv.CopyArray (native_intfs, intfs);
					JNIEnv.DeleteLocalRef (native_intfs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object)
		{
			const string __id = "getUIProxy.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz)
		{
			const string __id = "getUIProxy.(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			const string __id = "getUIProxy.(Ljava/lang/Object;Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [2] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getUIProxy' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;[]'] and parameter[3][@type='com.vivalnk.sdk.common.utils.proxy.ProxyInterceptor']]"
		[Register ("getUIProxy", "(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class[] intfs, global::Com.Vivalnk.Sdk.Common.Utils.Proxy.IProxyInterceptor interceptor)
		{
			const string __id = "getUIProxy.(Ljava/lang/Object;[Ljava/lang/Class;Lcom/vivalnk/sdk/common/utils/proxy/ProxyInterceptor;)Ljava/lang/Object;";
			IntPtr native_intfs = JNIEnv.NewArray (intfs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue (native_intfs);
				__args [2] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (intfs != null) {
					JNIEnv.CopyArray (native_intfs, intfs);
					JNIEnv.DeleteLocalRef (native_intfs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.common.utils.proxy']/class[@name='ProxyUtils']/method[@name='getWeakUIProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getWeakUIProxy", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetWeakUIProxy (global::Java.Lang.Object @object, global::Java.Lang.Class clazz)
		{
			const string __id = "getWeakUIProxy.(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
