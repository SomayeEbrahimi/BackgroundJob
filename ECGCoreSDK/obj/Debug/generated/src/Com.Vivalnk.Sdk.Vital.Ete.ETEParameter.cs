using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Vivalnk.Sdk.Vital.Ete {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']"
	[global::Android.Runtime.Register ("com/vivalnk/sdk/vital/ete/ETEParameter", DoNotGenerateAcw=true)]
	public partial class ETEParameter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='AGE_PARAMETER_LOWER_LIMIT']"
		[Register ("AGE_PARAMETER_LOWER_LIMIT")]
		public const int AgeParameterLowerLimit = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='AGE_PARAMETER_UPPER_LIMIT']"
		[Register ("AGE_PARAMETER_UPPER_LIMIT")]
		public const int AgeParameterUpperLimit = (int) 110;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='GENDER_MEN']"
		[Register ("GENDER_MEN")]
		public const int GenderMen = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='GENDER_WOMEN']"
		[Register ("GENDER_WOMEN")]
		public const int GenderWomen = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='HEIGHT_PARAMETER_LOWER_LIMIT']"
		[Register ("HEIGHT_PARAMETER_LOWER_LIMIT")]
		public const int HeightParameterLowerLimit = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='HEIGHT_PARAMETER_UPPER_LIMIT']"
		[Register ("HEIGHT_PARAMETER_UPPER_LIMIT")]
		public const int HeightParameterUpperLimit = (int) 250;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='HR_PARAMETER_UPPER_LIMIT']"
		[Register ("HR_PARAMETER_UPPER_LIMIT")]
		public const int HrParameterUpperLimit = (int) 220;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='WEIGHT_PARAMETER_LOWER_LIMIT']"
		[Register ("WEIGHT_PARAMETER_LOWER_LIMIT")]
		public const int WeightParameterLowerLimit = (int) 35;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='WEIGHT_PARAMETER_UPPER_LIMIT']"
		[Register ("WEIGHT_PARAMETER_UPPER_LIMIT")]
		public const int WeightParameterUpperLimit = (int) 250;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='accountId']"
		[Register ("accountId")]
		public string AccountId {
			get {
				const string __id = "accountId.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "accountId.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='age']"
		[Register ("age")]
		public int Age {
			get {
				const string __id = "age.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "age.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='gender']"
		[Register ("gender")]
		public int Gender {
			get {
				const string __id = "gender.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "gender.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/field[@name='weight']"
		[Register ("weight")]
		public int Weight {
			get {
				const string __id = "weight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "weight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/vivalnk/sdk/vital/ete/ETEParameter", typeof (ETEParameter));
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

		protected ETEParameter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.vivalnk.sdk.vital.ete']/class[@name='ETEParameter']/constructor[@name='ETEParameter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ETEParameter ()
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

	}
}
