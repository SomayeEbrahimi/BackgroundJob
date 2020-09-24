using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Open {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/open/SampleDataCache", DoNotGenerateAcw=true)]
	public partial class SampleDataCache : global::Java.Lang.Object, global::Java.IO.ISerializable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/field[@name='SIZE']"
		[Register ("SIZE")]
		public const int Size = (int) 60;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/field[@name='a']"
		[Register ("a")]
		public global::Java.Util.Concurrent.CopyOnWriteArrayList A {
			get {
				const string __id = "a.Ljava/util/concurrent/CopyOnWriteArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Ljava/util/concurrent/CopyOnWriteArrayList;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/open/SampleDataCache", typeof (SampleDataCache));
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

		protected SampleDataCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/constructor[@name='SampleDataCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SampleDataCache ()
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

		static Delegate cb_getDataSet;
#pragma warning disable 0169
		static Delegate GetGetDataSetHandler ()
		{
			if (cb_getDataSet == null)
				cb_getDataSet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSet);
			return cb_getDataSet;
		}

		static IntPtr n_GetDataSet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSet);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Vivalnk.Sdk.Open.DataSet DataSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='getDataSet' and count(parameter)=0]"
			[Register ("getDataSet", "()Lcom/vivalnk/sdk/open/DataSet;", "GetGetDataSetHandler")]
			get {
				const string __id = "getDataSet.()Lcom/vivalnk/sdk/open/DataSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getListSize;
#pragma warning disable 0169
		static Delegate GetGetListSizeHandler ()
		{
			if (cb_getListSize == null)
				cb_getListSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetListSize);
			return cb_getListSize;
		}

		static int n_GetListSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ListSize;
		}
#pragma warning restore 0169

		public virtual unsafe int ListSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='getListSize' and count(parameter)=0]"
			[Register ("getListSize", "()I", "GetGetListSizeHandler")]
			get {
				const string __id = "getListSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSampleDataList;
#pragma warning disable 0169
		static Delegate GetGetSampleDataListHandler ()
		{
			if (cb_getSampleDataList == null)
				cb_getSampleDataList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleDataList);
			return cb_getSampleDataList;
		}

		static IntPtr n_GetSampleDataList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SampleDataList);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Concurrent.CopyOnWriteArrayList SampleDataList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='getSampleDataList' and count(parameter)=0]"
			[Register ("getSampleDataList", "()Ljava/util/concurrent/CopyOnWriteArrayList;", "GetGetSampleDataListHandler")]
			get {
				const string __id = "getSampleDataList.()Ljava/util/concurrent/CopyOnWriteArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addData_arrayLcom_vivalnk_sdk_model_SampleData_;
#pragma warning disable 0169
		static Delegate GetAddData_arrayLcom_vivalnk_sdk_model_SampleData_Handler ()
		{
			if (cb_addData_arrayLcom_vivalnk_sdk_model_SampleData_ == null)
				cb_addData_arrayLcom_vivalnk_sdk_model_SampleData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddData_arrayLcom_vivalnk_sdk_model_SampleData_);
			return cb_addData_arrayLcom_vivalnk_sdk_model_SampleData_;
		}

		static void n_AddData_arrayLcom_vivalnk_sdk_model_SampleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Vivalnk.Sdk.Model.SampleData[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Vivalnk.Sdk.Model.SampleData));
			__this.AddData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='addData' and count(parameter)=1 and parameter[1][@type='com.vivalnk.sdk.model.SampleData...']]"
		[Register ("addData", "([Lcom/vivalnk/sdk/model/SampleData;)V", "GetAddData_arrayLcom_vivalnk_sdk_model_SampleData_Handler")]
		public virtual unsafe void AddData (params global::Com.Vivalnk.Sdk.Model.SampleData[] p0)
		{
			const string __id = "addData.([Lcom/vivalnk/sdk/model/SampleData;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_addDataList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddDataList_Ljava_util_List_Handler ()
		{
			if (cb_addDataList_Ljava_util_List_ == null)
				cb_addDataList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddDataList_Ljava_util_List_);
			return cb_addDataList_Ljava_util_List_;
		}

		static void n_AddDataList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddDataList (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='addDataList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.vivalnk.sdk.model.SampleData&gt;']]"
		[Register ("addDataList", "(Ljava/util/List;)V", "GetAddDataList_Ljava_util_List_Handler")]
		public virtual unsafe void AddDataList (global::System.Collections.Generic.IList<global::Com.Vivalnk.Sdk.Model.SampleData> p0)
		{
			const string __id = "addDataList.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Vivalnk.Sdk.Model.SampleData>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.vivalnk.sdk.open']/class[@name='SampleDataCache']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/vivalnk/sdk/open/SampleDataCache;", "GetCloneHandler")]
		public virtual unsafe global::Com.Vivalnk.Sdk.Open.SampleDataCache Clone ()
		{
			const string __id = "clone.()Lcom/vivalnk/sdk/open/SampleDataCache;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Vivalnk.Sdk.Open.SampleDataCache> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
