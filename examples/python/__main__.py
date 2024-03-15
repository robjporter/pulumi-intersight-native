import pulumi
import pulumi_intersight as intersight

my_random_resource = intersight.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})
