/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatchEvents.Model;

namespace Amazon.CloudWatchEvents
{
    /// <summary>
    /// Interface for accessing CloudWatchEvents
    ///
    /// Amazon CloudWatch Events helps you to respond to state changes in your AWS resources.
    /// When your resources change state, they automatically send events into an event stream.
    /// You can create rules that match selected events in the stream and route them to targets
    /// to take action. You can also use rules to take action on a predetermined schedule.
    /// For example, you can configure rules to:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Automatically invoke an AWS Lambda function to update DNS entries when an event notifies
    /// you that Amazon EC2 instance enters the running state.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Direct specific API records from AWS CloudTrail to an Amazon Kinesis data stream for
    /// detailed analysis of potential security or availability risks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Periodically invoke a built-in target to create a snapshot of an Amazon EBS volume.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the features of Amazon CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events">Amazon
    /// CloudWatch Events User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudWatchEvents : IAmazonService, IDisposable
    {

        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a>RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another AWS service on your behalf.
        /// These rules are created by those other AWS services to support functionality in those
        /// services. You can delete these rules using the <code>Force</code> option, but you
        /// should do so only if you are sure the other service is not still using that rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);



        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// Before you can delete the rule, you must remove all targets, using <a>RemoveTargets</a>.
        /// </para>
        ///  
        /// <para>
        /// When you delete a rule, incoming events might continue to match to the deleted rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// Managed rules are rules created and managed by another AWS service on your behalf.
        /// These rules are created by those other AWS services to support functionality in those
        /// services. You can delete these rules using the <code>Force</code> option, but you
        /// should do so only if you are sure the other service is not still using that rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventBus


        /// <summary>
        /// Displays the external AWS accounts that are permitted to write events to your account
        /// using your account's event bus, and the associated policy. To enable your account
        /// to receive events from other accounts, use <a>PutPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        DescribeEventBusResponse DescribeEventBus(DescribeEventBusRequest request);



        /// <summary>
        /// Displays the external AWS accounts that are permitted to write events to your account
        /// using your account's event bus, and the associated policy. To enable your account
        /// to receive events from other accounts, use <a>PutPermission</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventBus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventBus service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeEventBus">REST API Reference for DescribeEventBus Operation</seealso>
        Task<DescribeEventBusResponse> DescribeEventBusAsync(DescribeEventBusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRule


        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        DescribeRuleResponse DescribeRule(DescribeRuleRequest request);



        /// <summary>
        /// Describes the specified rule.
        /// 
        ///  
        /// <para>
        /// DescribeRule does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DescribeRule">REST API Reference for DescribeRule Operation</seealso>
        Task<DescribeRuleResponse> DescribeRuleAsync(DescribeRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableRule


        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        DisableRuleResponse DisableRule(DisableRuleRequest request);



        /// <summary>
        /// Disables the specified rule. A disabled rule won't match any events, and won't self-trigger
        /// if it has a schedule expression.
        /// 
        ///  
        /// <para>
        /// When you disable a rule, incoming events might continue to match to the disabled rule.
        /// Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/DisableRule">REST API Reference for DisableRule Operation</seealso>
        Task<DisableRuleResponse> DisableRuleAsync(DisableRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableRule


        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        EnableRuleResponse EnableRule(EnableRuleRequest request);



        /// <summary>
        /// Enables the specified rule. If the rule does not exist, the operation fails.
        /// 
        ///  
        /// <para>
        /// When you enable a rule, incoming events might not immediately start matching to a
        /// newly enabled rule. Allow a short period of time for changes to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/EnableRule">REST API Reference for EnableRule Operation</seealso>
        Task<EnableRuleResponse> EnableRuleAsync(EnableRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRuleNamesByTarget


        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// CloudWatch Events can invoke a specific target in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        ListRuleNamesByTargetResponse ListRuleNamesByTarget(ListRuleNamesByTargetRequest request);



        /// <summary>
        /// Lists the rules for the specified target. You can see which of the rules in Amazon
        /// CloudWatch Events can invoke a specific target in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleNamesByTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleNamesByTarget service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRuleNamesByTarget">REST API Reference for ListRuleNamesByTarget Operation</seealso>
        Task<ListRuleNamesByTargetResponse> ListRuleNamesByTargetAsync(ListRuleNamesByTargetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules();


        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);


        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists your Amazon CloudWatch Events rules. You can either list all the rules or you
        /// can provide a prefix to match to the rule names.
        /// 
        ///  
        /// <para>
        /// ListRules does not list the targets of a rule. To see the targets associated with
        /// a rule, use <a>ListTargetsByRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListRules">REST API Reference for ListRules Operation</seealso>
        Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a CloudWatch Events resource. In CloudWatch Events,
        /// rules can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Displays the tags associated with a CloudWatch Events resource. In CloudWatch Events,
        /// rules can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTargetsByRule


        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        ListTargetsByRuleResponse ListTargetsByRule(ListTargetsByRuleRequest request);



        /// <summary>
        /// Lists the targets assigned to the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsByRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetsByRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/ListTargetsByRule">REST API Reference for ListTargetsByRule Operation</seealso>
        Task<ListTargetsByRuleResponse> ListTargetsByRuleAsync(ListTargetsByRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Sends custom events to Amazon CloudWatch Events so that they can be matched to rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        PutEventsResponse PutEvents(PutEventsRequest request);



        /// <summary>
        /// Sends custom events to Amazon CloudWatch Events so that they can be matched to rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutEvents">REST API Reference for PutEvents Operation</seealso>
        Task<PutEventsResponse> PutEventsAsync(PutEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutPermission


        /// <summary>
        /// Running <code>PutPermission</code> permits the specified AWS account or AWS organization
        /// to put events to your account's default <i>event bus</i>. CloudWatch Events rules
        /// in your account are triggered by these events arriving to your default event bus.
        /// 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// a CloudWatch Events rule with your account's default event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple AWS accounts to put events to your default event bus, run <code>PutPermission</code>
        /// once for each of these accounts. Or, if all the accounts are members of the same AWS
        /// organization, you can run <code>PutPermission</code> once specifying <code>Principal</code>
        /// as "*" and specifying the AWS organization ID in <code>Condition</code>, to grant
        /// permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <code>RoleArn</code> with proper permissions when they use <code>PutTarget</code>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEvents-CrossAccountEventDelivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon CloudWatch Events User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the default event bus cannot exceed 10 KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        PutPermissionResponse PutPermission(PutPermissionRequest request);



        /// <summary>
        /// Running <code>PutPermission</code> permits the specified AWS account or AWS organization
        /// to put events to your account's default <i>event bus</i>. CloudWatch Events rules
        /// in your account are triggered by these events arriving to your default event bus.
        /// 
        /// 
        ///  
        /// <para>
        /// For another account to send events to your account, that external account must have
        /// a CloudWatch Events rule with your account's default event bus as a target.
        /// </para>
        ///  
        /// <para>
        /// To enable multiple AWS accounts to put events to your default event bus, run <code>PutPermission</code>
        /// once for each of these accounts. Or, if all the accounts are members of the same AWS
        /// organization, you can run <code>PutPermission</code> once specifying <code>Principal</code>
        /// as "*" and specifying the AWS organization ID in <code>Condition</code>, to grant
        /// permissions to all accounts in that organization.
        /// </para>
        ///  
        /// <para>
        /// If you grant permissions using an organization, then accounts in that organization
        /// must specify a <code>RoleArn</code> with proper permissions when they use <code>PutTarget</code>
        /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEvents-CrossAccountEventDelivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon CloudWatch Events User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The permission policy on the default event bus cannot exceed 10 KB in size.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.PolicyLengthExceededException">
        /// The event bus policy is too long. For more information, see the limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutPermission">REST API Reference for PutPermission Operation</seealso>
        Task<PutPermissionResponse> PutPermissionAsync(PutPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRule


        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a>DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <code>PutRule</code> command. If you omit arguments in <code>PutRule</code>,
        /// the old values for those arguments are not kept. Instead, they are replaced with null
        /// values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// When you initially create a rule, you can optionally assign one or more tags to the
        /// rule. Tags can help you organize and categorize your resources. You can also use them
        /// to scope user permissions, by granting a user permission to access or change only
        /// rules with certain tag values. To use the <code>PutRule</code> operation and assign
        /// tags, you must have both the <code>events:PutRule</code> and <code>events:TagResource</code>
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <code>PutRule</code>
        /// operation are ignored. To update the tags of an existing rule, use <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        ///  
        /// <para>
        /// In CloudWatch Events, it is possible to create rules that lead to infinite loops,
        /// where a rule is fired repeatedly. For example, a rule might detect that ACLs have
        /// changed on an S3 bucket, and trigger software to change them to the desired state.
        /// If the rule is not written carefully, the subsequent change to the ACLs fires the
        /// rule again, creating an infinite loop.
        /// </para>
        ///  
        /// <para>
        /// To prevent this, write the rules so that the triggered actions do not re-fire the
        /// same rule. For example, your rule could fire only if ACLs are found to be in a bad
        /// state, instead of after any change. 
        /// </para>
        ///  
        /// <para>
        /// An infinite loop can quickly cause higher than expected charges. We recommend that
        /// you use budgeting, which alerts you when charges exceed your specified limit. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/budgets-managing-costs.html">Managing
        /// Your Costs with Budgets</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        PutRuleResponse PutRule(PutRuleRequest request);



        /// <summary>
        /// Creates or updates the specified rule. Rules are enabled by default, or based on value
        /// of the state. You can disable a rule using <a>DisableRule</a>.
        /// 
        ///  
        /// <para>
        /// If you are updating an existing rule, the rule is replaced with what you specify in
        /// this <code>PutRule</code> command. If you omit arguments in <code>PutRule</code>,
        /// the old values for those arguments are not kept. Instead, they are replaced with null
        /// values.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a rule, incoming events might not immediately start matching
        /// to new or updated rules. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// A rule must contain at least an EventPattern or ScheduleExpression. Rules with EventPatterns
        /// are triggered when a matching event is observed. Rules with ScheduleExpressions self-trigger
        /// based on the given schedule. A rule can have both an EventPattern and a ScheduleExpression,
        /// in which case the rule triggers on matching events as well as on a schedule.
        /// </para>
        ///  
        /// <para>
        /// When you initially create a rule, you can optionally assign one or more tags to the
        /// rule. Tags can help you organize and categorize your resources. You can also use them
        /// to scope user permissions, by granting a user permission to access or change only
        /// rules with certain tag values. To use the <code>PutRule</code> operation and assign
        /// tags, you must have both the <code>events:PutRule</code> and <code>events:TagResource</code>
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// If you are updating an existing rule, any tags you specify in the <code>PutRule</code>
        /// operation are ignored. To update the tags of an existing rule, use <a>TagResource</a>
        /// and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        ///  
        /// <para>
        /// In CloudWatch Events, it is possible to create rules that lead to infinite loops,
        /// where a rule is fired repeatedly. For example, a rule might detect that ACLs have
        /// changed on an S3 bucket, and trigger software to change them to the desired state.
        /// If the rule is not written carefully, the subsequent change to the ACLs fires the
        /// rule again, creating an infinite loop.
        /// </para>
        ///  
        /// <para>
        /// To prevent this, write the rules so that the triggered actions do not re-fire the
        /// same rule. For example, your rule could fire only if ACLs are found to be in a bad
        /// state, instead of after any change. 
        /// </para>
        ///  
        /// <para>
        /// An infinite loop can quickly cause higher than expected charges. We recommend that
        /// you use budgeting, which alerts you when charges exceed your specified limit. For
        /// more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/budgets-managing-costs.html">Managing
        /// Your Costs with Budgets</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRule service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutRule">REST API Reference for PutRule Operation</seealso>
        Task<PutRuleResponse> PutRuleAsync(PutRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutTargets


        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// You can configure the following as targets for CloudWatch Events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EC2 instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Run Command
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Automation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Lambda functions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data streams in Amazon Kinesis Data Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data delivery streams in Amazon Kinesis Data Firehose
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS tasks
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Step Functions state machines
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Batch jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS CodeBuild projects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pipelines in AWS CodePipeline
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Inspector assessment templates
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS topics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS queues, including FIFO queues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default event bus of another AWS account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Creating rules with built-in targets is supported only in the AWS Management Console.
        /// The built-in targets are <code>EC2 CreateSnapshot API call</code>, <code>EC2 RebootInstances
        /// API call</code>, <code>EC2 StopInstances API call</code>, and <code>EC2 TerminateInstances
        /// API call</code>. 
        /// </para>
        ///  
        /// <para>
        /// For some target types, <code>PutTargets</code> provides target-specific parameters.
        /// If the target is a Kinesis data stream, you can optionally specify which shard the
        /// event goes to by using the <code>KinesisParameters</code> argument. To invoke a command
        /// on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon CloudWatch
        /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
        /// CloudWatch Events relies on resource-based policies. For EC2 instances, Kinesis data
        /// streams, and AWS Step Functions state machines, CloudWatch Events relies on IAM roles
        /// that you specify in the <code>RoleARN</code> argument in <code>PutTargets</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/auth-and-access-control-cwe.html">Authentication
        /// and Access Control</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If another AWS account is in the same region and has granted you permission (using
        /// <code>PutPermission</code>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <code>Arn</code> value
        /// when you run <code>PutTargets</code>. If your account sends events to another account,
        /// your account is charged for each sent event. Each event sent to another account is
        /// charged as a custom event. The account receiving the event is not charged. For more
        /// information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <code>RoleArn</code> with proper permissions
        /// in the <code>Target</code> structure. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEvents-CrossAccountEventDelivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon CloudWatch Events User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling cross-account events, see <a>PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <code>$.detail</code>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <code>InputPath</code> or <code>InputTransformer</code>, you must
        /// use JSON dot notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Allow a short period of time for
        /// changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        PutTargetsResponse PutTargets(PutTargetsRequest request);



        /// <summary>
        /// Adds the specified targets to the specified rule, or updates the targets if they are
        /// already associated with the rule.
        /// 
        ///  
        /// <para>
        /// Targets are the resources that are invoked when a rule is triggered.
        /// </para>
        ///  
        /// <para>
        /// You can configure the following as targets for CloudWatch Events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EC2 instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Run Command
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSM Automation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Lambda functions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data streams in Amazon Kinesis Data Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data delivery streams in Amazon Kinesis Data Firehose
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS tasks
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Step Functions state machines
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Batch jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS CodeBuild projects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pipelines in AWS CodePipeline
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Inspector assessment templates
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SNS topics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS queues, including FIFO queues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The default event bus of another AWS account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Creating rules with built-in targets is supported only in the AWS Management Console.
        /// The built-in targets are <code>EC2 CreateSnapshot API call</code>, <code>EC2 RebootInstances
        /// API call</code>, <code>EC2 StopInstances API call</code>, and <code>EC2 TerminateInstances
        /// API call</code>. 
        /// </para>
        ///  
        /// <para>
        /// For some target types, <code>PutTargets</code> provides target-specific parameters.
        /// If the target is a Kinesis data stream, you can optionally specify which shard the
        /// event goes to by using the <code>KinesisParameters</code> argument. To invoke a command
        /// on multiple EC2 instances with one rule, you can use the <code>RunCommandParameters</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// To be able to make API calls against the resources that you own, Amazon CloudWatch
        /// Events needs the appropriate permissions. For AWS Lambda and Amazon SNS resources,
        /// CloudWatch Events relies on resource-based policies. For EC2 instances, Kinesis data
        /// streams, and AWS Step Functions state machines, CloudWatch Events relies on IAM roles
        /// that you specify in the <code>RoleARN</code> argument in <code>PutTargets</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/auth-and-access-control-cwe.html">Authentication
        /// and Access Control</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If another AWS account is in the same region and has granted you permission (using
        /// <code>PutPermission</code>), you can send events to that account. Set that account's
        /// event bus as a target of the rules in your account. To send the matched events to
        /// the other account, specify that account's event bus as the <code>Arn</code> value
        /// when you run <code>PutTargets</code>. If your account sends events to another account,
        /// your account is charged for each sent event. Each event sent to another account is
        /// charged as a custom event. The account receiving the event is not charged. For more
        /// information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch
        /// Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are setting the event bus of another account as the target, and that account
        /// granted permission to your account through an organization instead of directly by
        /// the account ID, then you must specify a <code>RoleArn</code> with proper permissions
        /// in the <code>Target</code> structure. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEvents-CrossAccountEventDelivery.html">Sending
        /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon CloudWatch Events User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling cross-account events, see <a>PutPermission</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Input</b>, <b>InputPath</b>, and <b>InputTransformer</b> are mutually exclusive
        /// and optional parameters of a target. When a rule is triggered due to a matched event:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If none of the following arguments are specified for a target, then the entire event
        /// is passed to the target in JSON format (unless the target is Amazon EC2 Run Command
        /// or Amazon ECS task, in which case nothing from the event is passed to the target).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>Input</b> is specified in the form of valid JSON, then the matched event is
        /// overridden with this constant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputPath</b> is specified in the form of JSONPath (for example, <code>$.detail</code>),
        /// then only the part of the event specified in the path is passed to the target (for
        /// example, only the detail part of the event is passed).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <b>InputTransformer</b> is specified, then one or more specified JSONPaths are
        /// extracted from the event and used as values in a template that you specify as the
        /// input to the target.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify <code>InputPath</code> or <code>InputTransformer</code>, you must
        /// use JSON dot notation, not bracket notation.
        /// </para>
        ///  
        /// <para>
        /// When you add targets to a rule and the associated rule triggers soon after, new or
        /// updated targets might not be immediately invoked. Allow a short period of time for
        /// changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.LimitExceededException">
        /// You tried to create more rules or add more targets to a rule than is allowed.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/PutTargets">REST API Reference for PutTargets Operation</seealso>
        Task<PutTargetsResponse> PutTargetsAsync(PutTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Revokes the permission of another AWS account to be able to put events to your default
        /// event bus. Specify the account to revoke by the <code>StatementId</code> value that
        /// you associated with the account when you granted it permission with <code>PutPermission</code>.
        /// You can find the <code>StatementId</code> by using <a>DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);



        /// <summary>
        /// Revokes the permission of another AWS account to be able to put events to your default
        /// event bus. Specify the account to revoke by the <code>StatementId</code> value that
        /// you associated with the account when you granted it permission with <code>PutPermission</code>.
        /// You can find the <code>StatementId</code> by using <a>DescribeEventBus</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveTargets


        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        RemoveTargetsResponse RemoveTargets(RemoveTargetsRequest request);



        /// <summary>
        /// Removes the specified targets from the specified rule. When the rule is triggered,
        /// those targets are no longer be invoked.
        /// 
        ///  
        /// <para>
        /// When you remove a target, when the associated rule triggers, removed targets might
        /// continue to be invoked. Allow a short period of time for changes to take effect.
        /// </para>
        ///  
        /// <para>
        /// This action can partially fail if too many requests are made at the same time. If
        /// that happens, <code>FailedEntryCount</code> is non-zero in the response and each entry
        /// in <code>FailedEntries</code> provides the ID of the failed target and the error code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTargets service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/RemoveTargets">REST API Reference for RemoveTargets Operation</seealso>
        Task<RemoveTargetsResponse> RemoveTargetsAsync(RemoveTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Events resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In CloudWatch Events, rules can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a rule that already has tags.
        /// If you specify a new tag key for the rule, this tag is appended to the list of tags
        /// associated with the rule. If you specify a tag key that is already associated with
        /// the rule, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Events resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In CloudWatch Events, rules can be tagged.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to AWS and are interpreted strictly as strings
        /// of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a rule that already has tags.
        /// If you specify a new tag key for the rule, this tag is appended to the list of tags
        /// associated with the rule. If you specify a tag key that is already associated with
        /// the rule, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestEventPattern


        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        TestEventPatternResponse TestEventPattern(TestEventPatternRequest request);



        /// <summary>
        /// Tests whether the specified event pattern matches the provided event.
        /// 
        ///  
        /// <para>
        /// Most services in AWS treat : or / as the same character in Amazon Resource Names (ARNs).
        /// However, CloudWatch Events uses an exact match in event patterns and rules. Be sure
        /// to use the correct ARN characters when creating event patterns so that they match
        /// the ARN syntax in the event you want to match.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestEventPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestEventPattern service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InvalidEventPatternException">
        /// The event pattern is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/TestEventPattern">REST API Reference for TestEventPattern Operation</seealso>
        Task<TestEventPatternResponse> TestEventPatternAsync(TestEventPatternRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified CloudWatch Events resource. In CloudWatch
        /// Events, rules can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified CloudWatch Events resource. In CloudWatch
        /// Events, rules can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchEvents.</returns>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ConcurrentModificationException">
        /// There is concurrent modification on a rule or target.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ManagedRuleException">
        /// This rule was created by an AWS service on behalf of your account. It is managed by
        /// that service. If you see this error in response to <code>DeleteRule</code> or <code>RemoveTargets</code>,
        /// you can use the <code>Force</code> parameter in those calls to delete the rule or
        /// remove targets from the rule. You cannot modify these managed rules by using <code>DisableRule</code>,
        /// <code>EnableRule</code>, <code>PutTargets</code>, <code>PutRule</code>, <code>TagResource</code>,
        /// or <code>UntagResource</code>.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchEvents.Model.ResourceNotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/events-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}