$ProjectName = "dark-balancer-294711"
gcloud builds submit --project=$ProjectName --config gke-namespaces
gcloud builds submit --project=$ProjectName --config gke-messagequeue
gcloud builds submit --project=$ProjectName --config gke-frontendservice
gcloud builds submit --project=$ProjectName --config gke-clubservice
gcloud builds submit --project=$ProjectName --config gke-clubmemberservice
gcloud builds submit --project=$ProjectName --config gke-eventparticipantservice
gcloud builds submit --project=$ProjectName --config gke-eventservice
gcloud builds submit --project=$ProjectName --config gke-eventverificationservice
gcloud builds submit --project=$ProjectName --config gke-graphqlservice
gcloud builds submit --project=$ProjectName --config gke-identityservice
gcloud builds submit --project=$ProjectName --config gke-paymentservice
gcloud builds submit --project=$ProjectName --config gke-paymentwebhookservice
gcloud builds submit --project=$ProjectName --config gke-permissionservice
gcloud builds submit --project=$ProjectName --config gke-roomservice
gcloud builds submit --project=$ProjectName --config gke-subscriptionservice
gcloud builds submit --project=$ProjectName --config gke-websocketservice