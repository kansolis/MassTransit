﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Testing.TestInstanceConfigurators
{
	using System;
	using BuilderConfigurators;
	using Builders;
	using Scenarios;

	public interface ConsumerTestInstanceConfigurator<TScenario, TConsumer> :
		TestInstanceConfigurator<TScenario>
		where TConsumer : class
		where TScenario : TestScenario
	{
		void UseBuilder(Func<TScenario, ConsumerTestBuilder<TScenario, TConsumer>> builderFactory);
		void AddConfigurator(ConsumerTestBuilderConfigurator<TScenario, TConsumer> configurator);

		void UseConsumerFactory(IConsumerFactory<TConsumer> consumerFactory);
	}
}