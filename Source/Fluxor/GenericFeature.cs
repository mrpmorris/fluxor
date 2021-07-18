using System;

namespace Fluxor
{
	internal class GenericFeature<TState> : Feature<TState>
	{
		public string Name { get; }
		public TState InitialState { get; }

		public GenericFeature(
			string name,
			TState initialState,
			byte maximumStateChangedNotificationsPerSecond) : base()
		{
			if (string.IsNullOrWhiteSpace(name))
				throw new ArgumentException("Cannot be null or whitespace", paramName: nameof(name));

			Name = name;
			InitialState = initialState;
			State = initialState;
			MaximumStateChangedNotificationsPerSecond = maximumStateChangedNotificationsPerSecond;
		}


		public override string GetName() => Name;
		protected override TState GetInitialState() => InitialState;
	}
}
