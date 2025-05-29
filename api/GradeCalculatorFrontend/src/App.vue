<template>
  <div id="app">
    <h2>Grade Calculator</h2>
    <p>
      <b>{{ grade }}</b>
      <b>Weighting: {{ weighting }}</b>
    </p>
    <!-- Improved error message styling -->
    <p v-if="error" class="error-message">
      {{ error }}
    </p>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'App',
  data() {
    return {
      grade: 0,
      weighting: 0,
      error: null
    }
  },
  methods: {
    async calculateGrade() {
      try {
        const response = await axios.get('/api/gradecalculator/CalculateGrade')
        this.grade = response.data
      } catch (error) {
        console.error('Error calculating grade:', error)
        this.error = 'Failed to calculate grade'
      }
    }
  },
  mounted() {
    this.calculateGrade()
  }
}
</script>

<style>
.error-message {
  color: red;
  margin-top: 10px;
}
#app {
  padding: 20px;
}
</style>