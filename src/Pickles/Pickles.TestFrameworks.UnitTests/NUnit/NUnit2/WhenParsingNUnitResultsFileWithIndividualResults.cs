﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="WhenParsingNUnitResultsFileWithIndividualResults.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;

using NUnit.Framework;

using PicklesDoc.Pickles.TestFrameworks.NUnit.NUnit2;

namespace PicklesDoc.Pickles.TestFrameworks.UnitTests.NUnit.NUnit2
{
    [TestFixture]
    public class WhenParsingNUnitResultsFileWithIndividualResults : StandardTestSuiteForScenarioOutlines<NUnit2Results>
    {
        public WhenParsingNUnitResultsFileWithIndividualResults()
            : base("NUnit.NUnit2." + "results-example-nunit.xml")
        {
        }

        [Test]
        public new void ThenCanReadIndividualResultsFromScenarioOutline_AllPass_ShouldBeTestResultPassed()
        {
            base.ThenCanReadIndividualResultsFromScenarioOutline_AllPass_ShouldBeTestResultPassed();
        }

        [Test]
        public new void ThenCanReadIndividualResultsFromScenarioOutline_OneInconclusive_ShouldBeTestResultInconclusive()
        {
            base.ThenCanReadIndividualResultsFromScenarioOutline_OneInconclusive_ShouldBeTestResultInconclusive();
        }

        [Test]
        public new void ThenCanReadIndividualResultsFromScenarioOutline_OneFailed_ShouldBeTestResultFailed()
        {
            base.ThenCanReadIndividualResultsFromScenarioOutline_OneFailed_ShouldBeTestResultFailed();
        }

        [Test]
        public new void ThenCanReadIndividualResultsFromScenarioOutline_MultipleExampleSections_ShouldBeTestResultFailed()
        {
            base.ThenCanReadIndividualResultsFromScenarioOutline_MultipleExampleSections_ShouldBeTestResultFailed();
        }
    }
}