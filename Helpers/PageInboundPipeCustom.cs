using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Publishing;
using Telerik.Sitefinity.Publishing.Pipes;

namespace SitefinityWebApp
{
    public class PageInboundPipeCustom : PageInboundPipe
    {
        public override void PushData(IList<PublishingSystemEventInfo> items)
        {
            string searchIndexName = this.PipeSettings.PublishingPoint.Name;

            if (searchIndexName != "Idx_PCP" && searchIndexName != "Idx_Doc")
            {
                base.PushData(items);
            }

            List<PublishingSystemEventInfo> myItems = new List<PublishingSystemEventInfo>();



            foreach (var item in items)
            {
                PageNode node = null;

                if (item.Item is WrapperObject && ((WrapperObject)item.Item).WrappedObject != null)
                {
                    node = GetContentItem((WrapperObject)item.Item);
                }
                else
                {
                    node = ((PageNode)item.Item);
                }

                if (node.Page != null && node.Page.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live)
                {
                    while (true)
                    {

                        node = node.Parent;

                        if (node.Parent == null)
                        {
                            break;
                        }

                        if (searchIndexName == "Idx_PCP")
                        {
                            if (node.Title=="PCP")
                            {
                                myItems.Add(item);
                                // this will index only pages under Group page 1                            myItems.Add(item);
                                break;
                            }
                        }
                        if (searchIndexName == "Idx_Doc")
                        {
                            if (node.Title=="DOC")
                            {
                                myItems.Add(item);
                                // this will index only pages under Group page 2                                myItems.Add(item);
                                break;
                            }
                        }
                    }
                }
            }

            // pass the pages under the selected group page to the base PushData() method
            base.PushData(myItems);
        }
    }
}