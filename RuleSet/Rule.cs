﻿using System;

namespace RuleSet
{
	public class Rule<T1, TResult>
	{
		public Func<T1,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, TResult>
	{
		public Func<T1,T2,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, TResult>
	{
		public Func<T1,T2,T3,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, TResult>
	{
		public Func<T1,T2,T3,T4,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, T5, TResult>
	{
		public Func<T1,T2,T3,T4,T5,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,T5,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}

	public class Rule<T1, T2, T3, T4, T5, T6, TResult>
	{
		public Func<T1,T2,T3,T4,T5,T6,bool> Condition { get; set; }
		public TResult Result { get; set; }

		public Rule(Func<T1,T2,T3,T4,T5,T6,bool> condition, TResult result)
		{
			this.Condition = condition;
			this.Result = result;
		}
	}
}

