import * as pulumi from "@pulumi/pulumi";
import * as intersight from "@pulumi/intersight";

const myRandomResource = new intersight.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};
