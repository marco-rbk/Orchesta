---
trigger: always_on
---

# Kubernetes & GitOps Rules

- Output Kubernetes manifests in raw YAML format.
- Use Kustomize structure strictly: maintain generic resources in `base/` and environment-specific patches in `overlays/`.
- Use the Kubernetes Gateway API (`Gateway` and `HTTPRoute` resources) for all routing. Do not generate `Ingress` resources.
- Do not inject sidecars or annotations for Istio into the deployment manifests. The platform uses Istio Ambient Mesh (sidecar-less).
- Every `Deployment` must include Liveness, Readiness, and Startup Probes.
- Every `Deployment` must define explicit CPU and Memory `requests` and `limits`.
- Do not hardcode environment variables for secrets; use K8s `Secret` references or external secret operators.